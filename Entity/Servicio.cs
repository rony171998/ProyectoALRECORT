using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
        public Servicio(int iDServicio, string descripcion, string nombre, double costo)
        {
            IDServicio = iDServicio;
            Descripcion = descripcion;
            Nombre = nombre;
            Costo = costo;
        }

        public Servicio()
        {

        }

        public int IDServicio { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        
        

    }
}
