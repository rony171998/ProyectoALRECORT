using System;
using System.Collections.Generic;
using System.Text;
using Infraestructura;
using DAL;
using Entity;

namespace BLL
{
    public class DetalleService
    {
        private readonly ConnectionManager conexion;
        private readonly DetalleRepository repositorio;
        public DetalleService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new DetalleRepository(conexion);

        }

        public string Guardar(Detalle detalle)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                
                //if (repositorio.BuscarPorIdentificacion(detalle.Id_detalle) == null)
                //{

                    repositorio.Guardar(detalle);
                    //mensajeemail = email.EnviarEmail(detalle);
                    return $"Se guardaron detalles satisfactoriamente";
                //}
                //return $"La datalle ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.ToString()}";
            }
            finally { conexion.Close(); }
        }
        public string Eliminar(Detalle detalle)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                //if (repositorio.BuscarPorIdentificacion(detalle.Id_detalle) == null)
                //{
                    repositorio.Guardar(detalle);
                    //mensajeemail = email.EnviarEmail(detalle);
                    return $"Se guardaron los detalles satisfactoriamente";
                //}
                //return $"La persona ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public ConsultaDetalleRespuesta ConsultarTodos()
        {
            ConsultaDetalleRespuesta respuesta = new ConsultaDetalleRespuesta();
            try
            {

                conexion.Open();
                respuesta.detalles = repositorio.ConsultarTodos();
                conexion.Close();
                if (respuesta.detalles.Count > 0)
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


        public BusquedaDetalleRespuesta BuscarxIdentificacion(string identificacion)
        {
            BusquedaDetalleRespuesta respuesta = new BusquedaDetalleRespuesta();
            try
            {

                conexion.Open();
                respuesta.detalle = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.detalle != null) ? "Se encontró la Detalle buscada" : "La persona buscada no existe";
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

    public class ConsultaDetalleRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Detalle> detalles { get; set; }
    }


    public class BusquedaDetalleRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Detalle detalle { get; set; }
    }



    public class ConteoDetalleRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }

}
