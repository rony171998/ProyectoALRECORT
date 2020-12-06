using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Proveedor
    {
        public Proveedor(string identificacion, string nombre, string producto, string correo, string telefono)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Producto = producto;
            //Correo = correo;
            Telefono = telefono;
        }

        public Proveedor()
        {
        }

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Producto { get; set; }
        //public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}
