using System;
using DAL;
using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Transactions;
using System.Linq;
using System.Collections.Generic;
using Infraestructura;

namespace BLL
{
    public class ServicioService
    {
        private readonly ConnectionManager conexion;
        private readonly ServicioRepository repositorio;
        public ServicioService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ServicioRepository(conexion);

        }
        public string Guardar(Servicio servicio)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(servicio.IDServicio.ToString()) == null)
                {
                    repositorio.Guardar(servicio);
                //mensajeemail = email.EnviarEmail(servicio);
                    return $"Se guardaron los de {servicio.Nombre} datos satisfactoriamente";
               }
                return $"La persona ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Eliminar(Servicio servicio)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(servicio.IDServicio.ToString()) == null)
                {
                    repositorio.Guardar(servicio);
                    //mensajeemail = email.EnviarEmail(servicio);
                    return $"Se guardaron los de {servicio.Nombre} datos satisfactoriamente";
                }
                return $"La persona ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string ConsultarTodosservicios()
        {

            try
            {

                conexion.Open();
                repositorio.ConsultarTodos();
                conexion.Close();

                return "correcto";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }

            finally { conexion.Close(); }

        }
        public ConsultaServicioRespuesta ConsultarTodos()
        {
            ConsultaServicioRespuesta respuesta = new ConsultaServicioRespuesta();
            try
            {

                conexion.Open();
                respuesta.servicios = repositorio.ConsultarTodos();
                conexion.Close();
                if (respuesta.servicios.Count > 0)
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
        


        public BusquedaServicioRespuesta BuscarxIdentificacion(string identificacion)
        {
            BusquedaServicioRespuesta respuesta = new BusquedaServicioRespuesta();
            try
            {

                conexion.Open();
                respuesta.servicio = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.servicio != null) ? "Se encontró la Persona buscada" : "La persona buscada no existe";
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
        public ConteoServicioRespuesta Totalizar()
        {
            ConteoServicioRespuesta respuesta = new ConteoServicioRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.Totalizar(); ;
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = "Se consultan los Datos";

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

    public class ConsultaServicioRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Servicio> servicios { get; set; }
    }


    public class BusquedaServicioRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Servicio servicio { get; set; }
    }



    public class ConteoServicioRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }

}
    

