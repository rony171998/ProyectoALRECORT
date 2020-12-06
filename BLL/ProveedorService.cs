using System;
using System.Collections.Generic;
using System.Text;
using Infraestructura;
using DAL;
using Entity;

namespace BLL
{
    public class ProveedorService
    {
        private readonly ConnectionManager conexion;
        private readonly ProveedorRepository repositorio;
        public ProveedorService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ProveedorRepository(conexion);

        }
        public string Guardar(Proveedor proveedor)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(proveedor.Identificacion) == null)
                {
                    repositorio.Guardar(proveedor);
                    //mensajeemail = email.EnviarEmail(proveedor);
                    return $"Se guardaron los de {proveedor.Nombre} datos satisfactoriamente";
                }
                return $"La persona ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Eliminar(Proveedor proveedor)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(proveedor.Identificacion) == null)
                {
                    repositorio.Guardar(proveedor);
                    //mensajeemail = email.EnviarEmail(proveedor);
                    return $"Se guardaron los de {proveedor.Nombre} datos satisfactoriamente";
                }
                return $"La persona ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaProveedorRespuesta ConsultarTodos()
        {
            ConsultaProveedorRespuesta respuesta = new ConsultaProveedorRespuesta();
            try
            {

                conexion.Open();
                respuesta.proveedores = repositorio.ConsultarTodos();
                conexion.Close();
                if (respuesta.proveedores.Count > 0)
                {
                    respuesta.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    respuesta.Mensaje = "No hay datos para consultar";
                }
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }


        public BusquedaProveedorRespuesta BuscarxIdentificacion(string identificacion)
        {
            BusquedaProveedorRespuesta respuesta = new BusquedaProveedorRespuesta();
            try
            {

                conexion.Open();
                respuesta.proveedor = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.proveedor != null) ? "Se encontró la Proveedor buscada" : "La persona buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }



    }

    public class ConsultaProveedorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Proveedor> proveedores { get; set; }
    }


    public class BusquedaProveedorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Proveedor proveedor { get; set; }
    }



    public class ConteoProveedorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }

}
