using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
        public Servicio(string iDServicio, string nombre, double costo)
        {
            IDServicio = iDServicio;
            
            Nombre = nombre;
            Costo = costo;
        }

        public Servicio()
        {

        }

        public string IDServicio { get; set; }
        
        public string Nombre { get; set; }
        public double Costo { get; set; }
        
        

    }
}
