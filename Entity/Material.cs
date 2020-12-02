using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Material
    {
        public Material(string id, string nombre, int existencias)
        {
            Id = id;
            Nombre = nombre;
            Existencias = existencias;
        }

        public Material()
        {
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Existencias { get; set; }

        public int AgregarExistencias(int cantidad)
        {
                return Existencias += cantidad;
        }

        public int DescontarExistencias(int cantidad) 
        {

            return Existencias -= cantidad;
        }

        



    }
}
