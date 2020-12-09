using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Detalle
    {
        

        public string Id_detalle { get; set; }
        public string Id_Factura { get; set; }
        public string Id_Servicio { get; set; }
        public int Cantidad { get; set; }
        public double ValorTotal { get; set; }
        public double ValorUnitario { get; set; }
        public   Factura Factura { get; set; }
        public  Servicio Servicio { get; set; }
        public Detalle(Servicio servicio, int cantidad)
        {           
            Cantidad = cantidad;           
            ValorUnitario = servicio.Costo;
            Servicio = servicio;
            Id_Servicio = servicio.IDServicio;
            CalcularValor();
        }

        public Detalle()
        {
        }


        public double CalcularValor()
        {
            return ValorTotal=(ValorUnitario* Cantidad);
        }
    }
}
