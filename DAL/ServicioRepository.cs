using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Transactions;

namespace DAL
{
    public class ServicioRepository
    {
        private readonly OracleConnection _connection;
        private readonly List<Servicio> Servicioes = new List<Servicio>();
        public ServicioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Servicio servicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into servicio values (:ID,:Descripcion,:Precio)";
                command.Parameters.Add("ID", OracleDbType.Varchar2).Value = servicio.IDServicio;
                command.Parameters.Add("Descripcion", OracleDbType.Varchar2).Value = servicio.Nombre;
                command.Parameters.Add("Precio", OracleDbType.Double).Value = servicio.Costo;
                

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Eliminar(Servicio servicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from servicio where Id=:Id";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = servicio.IDServicio;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Modificar(Servicio servicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update servicio set Descripcion=:Descripcion,Precio=:Precio
                                        where Id=:Id";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = servicio.IDServicio;
                command.Parameters.Add("Descripcion", OracleDbType.Varchar2).Value = servicio.Nombre;
                command.Parameters.Add("Precio", OracleDbType.Varchar2).Value = servicio.Costo;
                OracleTransaction transaction = _connection.BeginTransaction();
                var filas = command.ExecuteNonQuery();
                transaction.Commit();
                return filas;
            }
        }
        public Servicio BuscarPorIdentificacion(string identificacion)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select ID,descripcion from servicio where ID=:Id ";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = identificacion;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Servicio servicio = DataReaderMapToPerson(dataReader);
                return servicio;
            }
        }
        private Servicio DataReaderMapToPerson(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Servicio servicio = new Servicio();
            servicio.IDServicio = dataReader.GetString(0);
            servicio.Nombre = dataReader.GetString(1);
            servicio.Costo = dataReader.GetFloat(2);
            
            return servicio;
        }
        public List<Servicio> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Servicio> servicioes = new List<Servicio>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from servicio";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Servicio servicio = DataReaderMapToPerson(dataReader);
                        servicioes.Add(servicio);
                    }
                }
            }
            return servicioes;
        }
    }
}
