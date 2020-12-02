using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Proveedor
    {
        public Proveedor(string identificacion, string nombre, string material, string correo, int telefono)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Material = material;
            Correo = correo;
            Telefono = telefono;
        }

        public Proveedor()
        {
        }

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Material { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
    }
}
