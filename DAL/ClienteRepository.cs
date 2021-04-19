using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Transactions;

namespace DAL
{
    public class ClienteRepository
    {
        private  readonly OracleConnection _connection;
        private readonly List<Cliente> Clientes = new List<Cliente>();
        public ClienteRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                //command.CommandText = @"begin 
                                        // PCK_PROYECTO.INSERTAR_CLIENTES(:Cedula,:PrimerNombre,:SegundoNombre,:PrimerApellido,:SegundoApellido,:edad,:sexo,:telefono);
                                        //end;";
                command.CommandText = "Insert Into clientes values (:Cedula,:PrimerNombre,:SegundoNombre," +
                    ":PrimerApellido,:SegundoApellido,:edad,:sexo,:telefono,:email,:fechaCita)";
                command.Parameters.Add("Cedula", OracleDbType.Varchar2).Value = cliente.Identificacion;
                command.Parameters.Add("PrimerNombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                command.Parameters.Add("SegundoNombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                command.Parameters.Add("PrimerApellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                command.Parameters.Add("SegundoApellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                command.Parameters.Add("edad", OracleDbType.Varchar2).Value = cliente.Edad;
                command.Parameters.Add("sexo", OracleDbType.Varchar2).Value = cliente.Sexo;
                command.Parameters.Add("telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                command.Parameters.Add("email", OracleDbType.Varchar2).Value = cliente.Email;
                command.Parameters.Add("fechaCita", OracleDbType.Date).Value = cliente.FechaCita;


                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Eliminar(string Identificacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from clientes where Cedula=:Cedula";
                command.Parameters.Add("Cedula", OracleDbType.Varchar2).Value = Identificacion;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Modificar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update clientes set PRIMER_NOMBRE=:primer_Nombre ,segundo_Nombre=:segundo_Nombre ,primer_Apellido=:primer_Apellido ,segundo_Apellido=:segundo_Apellido ,edad=:edad ,sexo=:sexo ,telefono=:telefono ,email=:email  where Cedula=:cedula";
                command.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cliente.Identificacion;
                command.Parameters.Add("primer_Nombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                command.Parameters.Add("segundo_Nombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                command.Parameters.Add("primer_Apellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                command.Parameters.Add("segundo_Apellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                command.Parameters.Add("edad", OracleDbType.Varchar2).Value = cliente.Edad;
                command.Parameters.Add("sexo", OracleDbType.Varchar2).Value = cliente.Sexo;
                command.Parameters.Add("telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                command.Parameters.Add("email", OracleDbType.Varchar2).Value = cliente.Email;
                //command.Parameters.Add("fechaCita", OracleDbType.Date).Value = cliente.FechaCita;

                OracleTransaction transaction = _connection.BeginTransaction();
                var filas = command.ExecuteNonQuery();
                transaction.Commit();
                return filas;
            }
        }
        public Cliente BuscarPorIdentificacion(string identificacion)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from clientes where cedula=:cedula";
                command.Parameters.Add("cedula", OracleDbType.Varchar2).Value = identificacion;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Cliente cliente = DataReaderMapToPerson(dataReader);
                return cliente;
            }
        }
        private Cliente DataReaderMapToPerson(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Cliente cliente = new Cliente();
            cliente.Identificacion = dataReader.GetString(0);
            cliente.PrimerNombre = dataReader.GetString(1);
            cliente.SegundoNombre = dataReader.GetString(2);
            cliente.PrimerApellido = dataReader.GetString(3);
            cliente.SegundoApellido = dataReader.GetString(4);
            cliente.Edad = dataReader.GetString(5);
            cliente.Sexo = dataReader.GetString(6);
            cliente.Telefono = dataReader.GetString(7);
            cliente.Email = dataReader.GetString(8);
            cliente.FechaCita = dataReader.GetDateTime(9);

            return cliente;
        }
        public List<Cliente> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Cliente> clientes = new List<Cliente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from clientes";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapToPerson(dataReader);
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }
    }
}
