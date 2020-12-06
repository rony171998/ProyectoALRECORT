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
                command.CommandText = "Insert Into clientes values (:Identificacion,:PrimerNombre,:SegundoNombre,:PrimerApellido,:SegundoApellido,:edad,:sexo,:telefono,:cargo)";
                command.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = cliente.Identificacion;
                command.Parameters.Add("PrimerNombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                command.Parameters.Add("SegundoNombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                command.Parameters.Add("PrimerApellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                command.Parameters.Add("SegundoApellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                command.Parameters.Add("edad", OracleDbType.Varchar2).Value = cliente.Edad;
                command.Parameters.Add("sexo", OracleDbType.Varchar2).Value = cliente.Sexo;
                command.Parameters.Add("telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                command.Parameters.Add("cargo", OracleDbType.Varchar2).Value = cliente.Cargo;

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Eliminar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from clientes where Identificacion=:Identificacion";
                command.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = cliente.Identificacion;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Modificar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update clientes set primerNombre=:PrimerNombre,segundoNombre=:SegundoNombre,primerApellido=:PrimerApellido,
                                        segundoApellido=:SegundoApellido, edad=:Edad, sexo=:Sexo,telefono=:Telefono,cargo=:Cargo
                                        where Identificacion=:Identificacion";

                command.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = cliente.Identificacion;
                command.Parameters.Add("PrimerNombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                command.Parameters.Add("SegundoNombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                command.Parameters.Add("PrimerApellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                command.Parameters.Add("SegundoApellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                command.Parameters.Add("Edad", OracleDbType.Varchar2).Value = cliente.Edad;
                command.Parameters.Add("Sexo", OracleDbType.Varchar2).Value = cliente.Sexo;
                command.Parameters.Add("Telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                command.Parameters.Add("Cargo", OracleDbType.Varchar2).Value = cliente.Cargo;
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
                command.CommandText = "select Identificacion,PrimerNombre from clientes where Identificacion=:Identificacion ";
                command.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = identificacion;
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
            cliente.Cargo = dataReader.GetString(8);
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
