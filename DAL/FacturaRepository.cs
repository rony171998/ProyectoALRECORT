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
                command.CommandText = "Insert Into factura values(SEQUENCE_FACTURA.nextval,:fecha,:total,:id_cliente)";
                
                command.Parameters.Add("fecha", OracleDbType.Date).Value = factura.Fecha;
                command.Parameters.Add("total", OracleDbType.Double).Value = factura.Total;
                command.Parameters.Add("id_cliente", OracleDbType.Varchar2).Value = factura.IdCliente;

                var filas = command.ExecuteNonQuery();
                return filas;
            }

        }

        public int Guardar(Factura factura)
        {
            //factura.IdFactura = (ConsultarTodos().Count() + 1).ToString(); // crear procedimiento que retorne el numero factura
            foreach (var item in factura.GetdetalleServicios())
            {
                item.Id_Factura = factura.IdFactura;
            }
            var filas =GuardarFactura(factura);
            int id_factura=BuscarFacturaPorFechayCliente(factura.Fecha,factura.IdCliente);
            foreach (var item in factura.GetdetalleServicios())
            {
                GuardarDetalle(item,id_factura);
            }
            return filas;
        }
        public int GuardarDetalle(Detalle detalle,int id_factura)
        {
           // detalle.Id_detalle = (ConsultarTodosDetalles().Count() + 1).ToString();// generar codigo desde base datos
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into detalle_factura values (SEQUENCE_DETALLE_FACTURA.NEXTVAL,:cantidad,:valorunitario,:valortotal,:id_factura,:servicio_id)";
                command.Parameters.Add("cantidad", OracleDbType.Int32).Value = detalle.Cantidad;
                command.Parameters.Add("valorunitario", OracleDbType.Double).Value = detalle.ValorUnitario;
                command.Parameters.Add("valortotal", OracleDbType.Double).Value = detalle.ValorTotal;
                command.Parameters.Add("id_factura", OracleDbType.Int32).Value = id_factura;
                command.Parameters.Add("servicio_id", OracleDbType.Int32).Value = int.Parse(detalle.Id_Servicio);
                
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        private Detalle DataReaderMapDetalle(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Detalle detalle = new Detalle();
            detalle.Id_detalle = dataReader.GetDecimal(0).ToString();
            detalle.Cantidad = dataReader.GetInt32(1);
            detalle.ValorUnitario = dataReader.GetDouble(2);
            detalle.ValorTotal = dataReader.GetDouble(3);
            detalle.Id_Factura = dataReader.GetDecimal(4).ToString();
            detalle.Id_Servicio = dataReader.GetDecimal(5).ToString();
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
                command.CommandText = "select * from factura where ID_FACTURA=:Id ";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = id;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Factura factura = DataReaderMapToFactura(dataReader);
                return factura;
            }
        }
        public int BuscarFacturaPorFechayCliente(DateTime fecha,string id_cliente)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from factura where fecha=:fecha and clientes_id=:id_cliente";
                command.Parameters.Add("fecha", OracleDbType.Date).Value = fecha;
                command.Parameters.Add("id_cliente", OracleDbType.Varchar2).Value = id_cliente;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Factura factura = DataReaderMapToFactura(dataReader);
                return int.Parse(factura.IdFactura);
            }
        }
        public List<Factura> BuscarPorIdcliente(string id)
        {
            OracleDataReader dataReader;
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from factura where CLIENTES_ID=:Id ";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = id;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Factura factura = DataReaderMapToFactura(dataReader);
                return facturas;
            }
        }

        private Factura DataReaderMapToFactura(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Factura factura = new Factura();
            factura.IdFactura = dataReader.GetDecimal(0).ToString();
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
