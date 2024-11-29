using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Entidades
{
    public static class UsuarioVerificado
    {
        public static int Id { get; set; }

        public static string Nombre { get; set; }
        public static string Apellido { get; set; } 
        public static string Correo {  get; set; }

        public static int RolId { get; set; }


    }
}
