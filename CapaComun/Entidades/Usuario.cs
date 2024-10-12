﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Entidades
{
    public class Usuario
    {
        public int Id {  get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad {  get; set; }

        public string Clave { get; set; }

        public string Telefono {  get; set; } 

        public string Correo { get; set; }

        public int IdRol {  get; set; }

    }
}
