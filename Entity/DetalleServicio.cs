using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleServicio
    {
        

        public string Id { get; set; }
        public string Descripcion { get; set; }
        public Factura factura { get; set; }
        public Servicio Servicio { get; set; }
        public int Cantidad { get; set; }
        public int Valor { get; set; }

        public DetalleServicio(Servicio servicio, int cantidad)
        {
            Servicio = servicio;
            Cantidad = cantidad;
        }

        public void CalcularValor()
        {
            Valor=Convert.ToInt32(Servicio.Costo* Cantidad);
        }
    }
}
