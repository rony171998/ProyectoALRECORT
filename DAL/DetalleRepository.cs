using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Transactions;

namespace DAL
{
    public class DetalleRepository
    {
        private readonly OracleConnection _connection;
        private readonly List<Detalle> Detalles = new List<Detalle>();
        public DetalleRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public int Guardar(Detalle detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into detalle_factura values (:detalle_id,:cantidad,:valorunitario,:valortotal,:servicio_id,id_factura)";
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
        public int Eliminar(Detalle detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from detalle where Id=:Id";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = detalle.Id_detalle;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Modificar(Detalle detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update detalle_factura set Descripcion=:Descripcion,Precio=:Precio where Id=:Id";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = detalle.Id_detalle;
                command.Parameters.Add("Descripcion", OracleDbType.Varchar2).Value = detalle.Id_detalle;
                command.Parameters.Add("Precio", OracleDbType.Varchar2).Value = detalle.ValorUnitario;
                OracleTransaction transaction = _connection.BeginTransaction();
                var filas = command.ExecuteNonQuery();
                transaction.Commit();
                return filas;
            }
        }
        public Detalle BuscarPorIdentificacion(string identificacion)
        {
            OracleDataReader dataReader ;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select id_detalle from detalle_factura where id_detalle=:id_detalle ";
                command.Parameters.Add("id_detalle", OracleDbType.Varchar2).Value = identificacion;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Detalle detalle = DataReaderMapToPerson(dataReader);
                return detalle;
            }
        }
        private Detalle DataReaderMapToPerson(OracleDataReader dataReader)
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
        public List<Detalle> ConsultarTodos()
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
                        Detalle detalle = DataReaderMapToPerson(dataReader);
                        detalles.Add(detalle);
                    }
                }
            }
            return detalles;
        }
    }
}
