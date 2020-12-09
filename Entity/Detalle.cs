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

        public Detalle(string id_servicio, int cantidad,string id_factura,int valorUnitario,int valorTotal,string id_detalle)
        {
            Id_Servicio = id_servicio;
            Cantidad = cantidad;
            ValorTotal = valorTotal;
            ValorUnitario = valorUnitario;
            Id_detalle = id_detalle;
            Id_Factura = id_factura;
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
