using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Transactions;

namespace DAL
{
    public class ProveedorRepository
    {
        private readonly OracleConnection _connection;
        private readonly List<Proveedor> Proveedores = new List<Proveedor>();
        public ProveedorRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Proveedor proveedor)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into proveedores values (:ID,:Nombre,:Telefono,:Producto)";
                command.Parameters.Add("ID", OracleDbType.Varchar2).Value = proveedor.Identificacion;
                command.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = proveedor.Nombre;
                command.Parameters.Add("Telefono", OracleDbType.Varchar2).Value = proveedor.Telefono;
                command.Parameters.Add("Producto", OracleDbType.Varchar2).Value = proveedor.Producto;

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Eliminar(Proveedor proveedor)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from proveedores where Identificacion=:Identificacion";
                command.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = proveedor.Identificacion;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Modificar(Proveedor proveedor)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update proveedores set Nombre=:Nombre,telefono=:Telefono,producto=:Producto
                                        where Identificacion=:Identificacion";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = proveedor.Identificacion;
                command.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = proveedor.Nombre;
                command.Parameters.Add("Telefono", OracleDbType.Varchar2).Value = proveedor.Telefono;
                command.Parameters.Add("Producto", OracleDbType.Varchar2).Value = proveedor.Producto;
                OracleTransaction transaction = _connection.BeginTransaction();
                var filas = command.ExecuteNonQuery();
                transaction.Commit();
                return filas;
            }
        }
        public Proveedor BuscarPorIdentificacion(string identificacion)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select ID,Nombre from proveedores where ID=:Id ";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = identificacion;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Proveedor proveedor = DataReaderMapToPerson(dataReader);
                return proveedor;
            }
        }
        private Proveedor DataReaderMapToPerson(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Proveedor proveedor = new Proveedor();
            proveedor.Identificacion = dataReader.GetString(0);
            proveedor.Nombre = dataReader.GetString(1);
            proveedor.Telefono = dataReader.GetString(2);
            proveedor.Producto = dataReader.GetString(3);
            return proveedor;
        }
        public List<Proveedor> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Proveedor> proveedores = new List<Proveedor>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from proveedores";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Proveedor proveedor = DataReaderMapToPerson(dataReader);
                        proveedores.Add(proveedor);
                    }
                }
            }
            return proveedores;
        }
    }
}
