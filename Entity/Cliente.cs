﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public Cliente(string identificacion, string primerNombre, string segundoNombre, string primerApellido, 
            string segundoApellido, string edad, string sexo, string telefono,string email,DateTime fechaCita)
        {
            Identificacion = identificacion;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Edad = edad;
            Sexo = sexo;
            Telefono = telefono;           
            Email = email;
            FechaCita = fechaCita;
        }

        public Cliente()
        {

        }

        public string Identificacion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Edad { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCita { get; set; }
        public string Email { get; set; }



    }
}
