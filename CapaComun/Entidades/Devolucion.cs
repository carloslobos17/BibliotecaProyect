using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Entidades
{
    public class Devolucion
    {
        public int Id { get; set; }

        public DateTime FechaDevolucion {  get; set; }
        
        public string Observaciones { get; set; }

        public int IdPrestamo { get; set; }


    }
}
