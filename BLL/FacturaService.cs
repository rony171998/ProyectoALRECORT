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
    public class FacturaService
    {
        private readonly ConnectionManager conexion;
        private readonly FacturaRepository repositorio;
        public FacturaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new FacturaRepository(conexion);

        }
        public double calcularTotal(Factura factura)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdFactura(factura.IdFactura) == null)
                {
                    return repositorio.CalcularTotal(factura);
                    
                    
                }
                return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
            finally { conexion.Close(); }
        }

        public string Guardar(Factura factura)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                //if (repositorio.BuscarPorIdFactura(factura.IdFactura) == null)
                //{
                    repositorio.Guardar(factura);
                    //mensajeemail = email.EnviarEmail(cliente);
                    return $"Se guardaron los datos de la factura {factura.IdFactura} satisfactoriamente";
                //}
                //return $"La factura ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public string Eliminar(Factura factura)
        {
            Email email = new Email();
            string mensajeemail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdFactura(factura.IdFactura) != null)
                {
                    repositorio.Eliminar(factura);
                    //mensajeemail = email.EnviarEmail(cliente);
                    return $"Se ha Eliminado la factura {factura.IdFactura} satisfactoriamente";
                }
                return $"La Factura Buscada No se Encuentra Registrada";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaFacturaRespuesta ConsultarTodos()
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.facturas = repositorio.ConsultarTodos();
                conexion.Close();
                if (respuesta.facturas.Count > 0)
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


        public ConsultaFacturaRespuesta BuscarxIdentificacion(string identificacion)
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.facturas = repositorio.BuscarPorIdcliente(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.facturas != null) ? "Se encontró la Factura buscada" : "La persona buscada no existe";
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
        public BusquedaFacturaRespuesta Buscarxfactura(string identificacion)
        {
            BusquedaFacturaRespuesta respuesta = new BusquedaFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.factura = repositorio.BuscarPorIdFactura(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.factura != null) ? "Se encontró la Factura buscada" : "La persona buscada no existe";
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
    





public class ConsultaFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Factura> facturas { get; set; }
    }


    public class BusquedaFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Factura factura { get; set; }
    }



    public class ConteoFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
