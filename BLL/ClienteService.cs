using System;
using Oracle.ManagedDataAccess.Client;
using System.Transactions;
using System.Linq;
using System.Collections.Generic;
using Infraestructura;
using DAL;
using Entity;

namespace BLL
{
    public class ClienteService
    {
        private readonly ConnectionManager conexion;
        private readonly ClienteRepository repositorio;
        public ClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ClienteRepository(conexion);

        }
        public string Guardar(Cliente cliente)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(cliente.Identificacion) == null)
                {
                    repositorio.Guardar(cliente);
                //mensajeemail = email.EnviarEmail(cliente);
                    return $"Se guardaron los de {cliente.PrimerNombre} datos satisfactoriamente";
                }
                return $"La persona ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Modificar(Cliente cliente)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(cliente.Identificacion) == null)
                {
                    return $"La persona no existe";
                }
                else
                {
                    repositorio.Modificar(cliente);
                    //mensajeemail = email.EnviarEmail(cliente);
                    return $"Se modificaron los datos de {cliente.PrimerNombre} satisfactoriamente";
                    
                }
                
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.ToString()}";
            }
            finally { conexion.Close(); }
        }
        public string Eliminar(string identificacion)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(identificacion) != null)
                {
                    repositorio.Eliminar(identificacion);
                    //mensajeemail = email.EnviarEmail(cliente);
                    return $"Se elimino correctamente";
                }
                return $"La persona no existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaPersonaRespuesta ConsultarTodos()
        {
            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();
            try
            {

                conexion.Open();
                respuesta.clientes = repositorio.ConsultarTodos();
                conexion.Close();
                if (respuesta.clientes.Count > 0)
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

        
        public BusquedaPersonaRespuesta BuscarxIdentificacion(string identificacion)
        {
            BusquedaPersonaRespuesta respuesta = new BusquedaPersonaRespuesta();
            try
            {
                conexion.Open();
                respuesta.cliente = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.cliente != null) ? "Se encontró la Persona buscada" : "La persona buscada no existe";
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

    public class ConsultaPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Cliente> clientes { get; set; }
    }


    public class BusquedaPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente cliente { get; set; }
    }



    public class ConteoPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }

}
    

