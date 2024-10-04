using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginBiblioteca
{
    public class Login
    {
        private string Usuario = "Admin";
        private string Contrasena = "123";

        public Login()
        {
        }

        public Login(string usuario, string contrasena)
        {
            Usuario = usuario;
            Contrasena = contrasena;
        }

        public bool ValidacionCredenciales(string usuario, string contrasena)
        {
            return usuario == Usuario && contrasena == Contrasena;
        }
    }
}
