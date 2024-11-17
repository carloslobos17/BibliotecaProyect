using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Entidades
{
    public class Libro
    {
        public int Id { get; set; }

        public string Titulo{ get; set; }
        public string Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int CopiasDisponibles { get; set; }
        public int IdCategoria { get; set; }
    }
}
