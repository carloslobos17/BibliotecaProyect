﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Entidades
{
    public class Prestamo
    {
        public int Id { get; set; }

        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public int IdUsuario { get; set; }

        public int IdLibro { get; set; }

        public bool Activo { get; set; }

    }
}
