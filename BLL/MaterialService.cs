using System;
using System.Collections.Generic;
using System.Text;
using Infraestructura;
using DAL;
using Entity;

namespace BLL
{
    public class MaterialService
    {
        private readonly ConnectionManager conexion;
        private readonly MaterialRepository repositorio;
        public MaterialService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new MaterialRepository(conexion);

        }
        public string Guardar(Material material)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(material.Id) == null)
                {
                    repositorio.Guardar(material);
                    //mensajeemail = email.EnviarEmail(material);
                    return $"Se guardaron los de {material.Nombre} datos satisfactoriamente";
                }
                return $"La persona ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Eliminar(Material material)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(material.Id) == null)
                {
                    repositorio.Guardar(material);
                    //mensajeemail = email.EnviarEmail(material);
                    return $"Se guardaron los de {material.Nombre} datos satisfactoriamente";
                }
                return $"La persona ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaMaterialRespuesta ConsultarTodos()
        {
            ConsultaMaterialRespuesta respuesta = new ConsultaMaterialRespuesta();
            try
            {

                conexion.Open();
                respuesta.materiales = repositorio.ConsultarTodos();
                conexion.Close();
                if (respuesta.materiales.Count > 0)
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


        public BusquedaMaterialRespuesta BuscarxIdentificacion(string identificacion)
        {
            BusquedaMaterialRespuesta respuesta = new BusquedaMaterialRespuesta();
            try
            {

                conexion.Open();
                respuesta.material = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.material != null) ? "Se encontró la Material buscada" : "La persona buscada no existe";
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

    public class ConsultaMaterialRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Material> materiales { get; set; }
    }


    public class BusquedaMaterialRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Material material { get; set; }
    }



    public class ConteoMaterialRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }

}

