using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public Factura(string idFactura, DateTime fecha, int total,string idCliente)
        {
            IdFactura = idFactura;
            Fecha = fecha;           
            Total = total;
            IdCliente = idCliente;

        }

        public Factura()
        {
            detalleServicios = new List<Detalle>();
        }

        public string IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        
        public double Total { get; set; }
        public string IdCliente { get; set; }

        private List<Detalle> detalleServicios;

        public Detalle AgregarDetalleServicio(Servicio servicio, int cantidad)
        {
            if (cantidad <= 0)
            {
                return null;
            }
            else
            {
                Detalle detalleServicio = new Detalle(servicio, cantidad);
                detalleServicio.Factura = this;
                detalleServicios.Add(detalleServicio);
                return detalleServicio;
            }
        }
        public void CalcularTotal()
        {
            Total=detalleServicios.Sum(d => d.ValorTotal);
            
        }


        public List<Detalle> GetdetalleServicios()
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
