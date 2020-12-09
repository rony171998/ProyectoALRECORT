using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Transactions;

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
        public int Guardar(Factura factura)
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
