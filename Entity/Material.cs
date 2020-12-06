using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Material
    {
        public Material(string id, string nombre, int existencias, DateTime fechaRegistro,string idProveedor)
        {
            Id = id;
            Nombre = nombre;
            Existencias = existencias;
            FechaRegistro = fechaRegistro;
            IdProveedor = idProveedor;

        }

        public Material()
        {
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Existencias { get; set; }

        public DateTime FechaRegistro { get; set; }
        public string IdProveedor { get; set; }

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
