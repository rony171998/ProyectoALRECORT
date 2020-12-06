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
    public class ServicioRepository
    {
        private  readonly OracleConnection _connection;
        private readonly List<Servicio> servicios = new List<Servicio>();
        public ServicioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Servicio servicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into servicio values (:ID,:descripcion,:precio)";
                command.Parameters.Add("IDservicio", OracleDbType.Varchar2).Value = servicio.IDServicio;
                command.Parameters.Add("descripcion", OracleDbType.Varchar2).Value = servicio.Nombre;
                command.Parameters.Add("precio", OracleDbType.Varchar2).Value = servicio.Costo;

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Eliminar(Servicio servicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from servicio where ID=:Identificacion";
                command.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = servicio.IDServicio;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Modificar(Servicio servicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update servicio set descripcion=:Nombre,precio=:Costo where ID=:IDservicio";

                command.Parameters.Add("IDservicio", OracleDbType.Varchar2).Value = servicio.IDServicio;
                command.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = servicio.Nombre;
                command.Parameters.Add("Costo", OracleDbType.Varchar2).Value = servicio.Costo;
                
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
                command.CommandText = "select ID,descripcion from servicio where ID=:ID ";
                command.Parameters.Add("ID", OracleDbType.Varchar2).Value = identificacion;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Servicio servicio = DataReaderMapToServicio(dataReader);
                return servicio;
            }
        }
        private Servicio DataReaderMapToServicio(OracleDataReader dataReader)
        {
            
            Servicio servicio = new Servicio();
            servicio.IDServicio =dataReader.GetString(0);
            servicio.Nombre = dataReader.GetString(1);
            servicio.Costo = dataReader.GetString(2);
            
            return servicio;
        }
        
        public List<Servicio> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Servicio> servicios = new List<Servicio>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from servicio ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Servicio servicio = DataReaderMapToServicio(dataReader);
                        servicios.Add(servicio);
                    }
                }
            }
            return servicios;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
    }
}
