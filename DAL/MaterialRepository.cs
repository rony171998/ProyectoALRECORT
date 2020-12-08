using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Transactions;

namespace DAL
{
    public class MaterialRepository
    {
        private readonly OracleConnection _connection;
        private readonly List<Material> Materiales = new List<Material>();
        public MaterialRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Material material)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into materiales values (:ID,:Nombre,:FechaRegistro,:Idproveedor,:Cantidad)";
                command.Parameters.Add("ID", OracleDbType.Varchar2).Value = material.Id;
                command.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = material.Nombre;
                command.Parameters.Add("Fecharegistro", OracleDbType.Date).Value = material.FechaRegistro;             
                command.Parameters.Add("IdProveedor", OracleDbType.Varchar2).Value = material.IdProveedor;
                command.Parameters.Add("Cantidad", OracleDbType.Int16).Value = material.Existencias;

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Eliminar(Material material)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from materiales where Id=:Identificacion";
                command.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = material.Id;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int Modificar(Material material)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update materiales set Descripcion=:Nombre,fecha_Registro=:Fecharegistro,IdProveedor=:IdProveedor,Cantidad=:Cantidad
                                        where Id=:Id";
                command.Parameters.Add("ID", OracleDbType.Varchar2).Value = material.Id;
                command.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = material.Nombre;
                command.Parameters.Add("Fecharegistro", OracleDbType.Date).Value = material.FechaRegistro;
                command.Parameters.Add("IdProveedor", OracleDbType.Varchar2).Value = material.IdProveedor;
                command.Parameters.Add("Cantidad", OracleDbType.Varchar2).Value = material.Existencias;
                OracleTransaction transaction = _connection.BeginTransaction();
                var filas = command.ExecuteNonQuery();
                transaction.Commit();
                return filas;
            }
        }
        public Material BuscarPorIdentificacion(string identificacion)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select ID,Descripcion from materiales where ID=:Id ";
                command.Parameters.Add("Id", OracleDbType.Varchar2).Value = identificacion;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Material material = DataReaderMap(dataReader);
                return material;
            }
        }
        private Material DataReaderMap(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Material material = new Material();
            material.Id = dataReader.GetString(0);
            material.Nombre = dataReader.GetString(1);
            material.FechaRegistro = dataReader.GetDateTime(2);
            material.IdProveedor = dataReader.GetString(3);
            material.Existencias = dataReader.GetInt16(4);
            return material;
        }
        public List<Material> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Material> materiales = new List<Material>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from materiales";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Material material = DataReaderMap(dataReader);
                        materiales.Add(material);
                    }
                }
            }
            return materiales;
        }
    }
}
