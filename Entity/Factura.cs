using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public Factura(long idFactura, DateTime fecha, Cliente cliente, int total)
        {
            IdFactura = idFactura;
            Fecha = fecha;
            Cliente = cliente;
            Total = total;
        }

        public Factura()
        {
        }

        public long IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public int Total { get; set; }

        private List<DetalleServicio> detalleServicios;

        public DetalleServicio AgregarDetalleServicio(Servicio servicio, int cantidad)
        {
            if (cantidad<=0)
            {
                return null;
            }
            else
            {
                DetalleServicio detalleServicio = new DetalleServicio(servicio, cantidad);
                detalleServicio.factura = this;
                detalleServicios.Add(detalleServicio);
                return detalleServicio;
            }
        }

        public List<DetalleServicio> GetdetalleServicios()
        {
            return detalleServicios;
        }

        public int GenerarID()
        {
            int numeroAleatorio = new Random().Next(1, 100000);
            return numeroAleatorio;
        }



    }
}
