using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Transactions;
using System.Linq;

namespace DAL
{
    public class FacturaRepository
    {
        private readonly OracleConnection _connection;
        private readonly List<Cliente> Clientes = new List<Cliente>();
        public FacturaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public double CalcularTotal(Factura factura )
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select sum(valor_total) from detalle_factura where id_factura=:id_factura ";
                command.Parameters.Add("id_factura", OracleDbType.Varchar2).Value = factura.IdFactura;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int GuardarFactura(Factura factura)
        {           
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into factura values(:id_factura,:fecha,:total,:id_cliente)";
                command.Parameters.Add("id_factura",OracleDbType.Varchar2).Value = factura.IdFactura;
                command.Parameters.Add("fecha", OracleDbType.Date).Value = factura.Fecha;
                command.Parameters.Add("total", OracleDbType.Double).Value = factura.Total;
                command.Parameters.Add("id_cliente", OracleDbType.Varchar2).Value = factura.IdCliente;

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Guardar(Factura factura)
        {
            factura.IdFactura = (ConsultarTodos().Count() + 1).ToString(); // crear procedimiento que retorne el numero factura
            foreach (var item in factura.GetdetalleServicios())
            {
                item.Id_Factura = factura.IdFactura;
            }
            var filas =GuardarFactura(factura);
            foreach (var item in factura.GetdetalleServicios())
            {
                GuardarDetalle(item);

            }
            return filas;
            


        }
        public int GuardarDetalle(Detalle detalle)
        {
            detalle.Id_detalle = (ConsultarTodosDetalles().Count() + 1).ToString();// generar codigo desde base datos
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into detalle_factura values (:detalle_id,:cantidad,:valorunitario,:valortotal,:servicio_id,:id_factura)";
                command.Parameters.Add("detalle_id", OracleDbType.Varchar2).Value = detalle.Id_detalle;
                command.Parameters.Add("cantidad", OracleDbType.Int32).Value = detalle.Cantidad;
                command.Parameters.Add("valorunitario", OracleDbType.Double).Value = detalle.ValorUnitario;
                command.Parameters.Add("valortotal", OracleDbType.Double).Value = detalle.ValorTotal;
                command.Parameters.Add("servicio_id", OracleDbType.Varchar2).Value = detalle.Id_Servicio;
                command.Parameters.Add("id_factura", OracleDbType.Varchar2).Value = detalle.Id_Factura;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        private Detalle DataReaderMapDetalle(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Detalle detalle = new Detalle();
            detalle.Id_detalle = dataReader.GetString(0);
            detalle.Cantidad = dataReader.GetInt32(1);
            detalle.ValorUnitario = dataReader.GetDouble(2);
            detalle.ValorTotal = dataReader.GetDouble(3);
            detalle.Id_Servicio = dataReader.GetString(4);
            detalle.Id_Factura = dataReader.GetString(5);

            return detalle;
        }
        public List<Detalle> ConsultarTodosDetalles()
        {
            OracleDataReader dataReader;
            List<Detalle> detalles = new List<Detalle>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from detalle_factura";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Detalle detalle = DataReaderMapDetalle(dataReader);
                        detalles.Add(detalle);
                    }
                }
            }
            return detalles;
        }


        public int Eliminar(Factura factura)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from factura where ID_FACTURA=:IdFactura";
                command.Parameters.Add("IdFactura", OracleDbType.Varchar2).Value = factura.IdFactura;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }

        public Factura BuscarPorIdFactura(string id)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select ID_FACTURA from factura where ID_FACTURA=:Id ";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = id;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Factura factura = DataReaderMapToFactura(dataReader);
                return factura;
            }
        }

        private Factura DataReaderMapToFactura(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Factura factura = new Factura();
            factura.IdFactura = dataReader.GetString(0);
            factura.Fecha = dataReader.GetDateTime(1);
            factura.Total =dataReader.GetDouble(2);
            factura.IdCliente = dataReader.GetString(3);

            return factura;
        }

        public List<Factura> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from factura";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
            return facturas;
        }
    }
}
