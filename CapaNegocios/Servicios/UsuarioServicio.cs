using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Repositorios;
using CapaEntidad.Entidades;


namespace CapaNegocios.Servicios
{
    public class UsuarioServicio
    {
        private UsuarioRepositorio _usuarioRepositorio;
        public UsuarioServicio()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        public int AutenticarUsuario(string usuario, string clave)
        {
            return _usuarioRepositorio.AutenticarUsuario(usuario, clave);
        }

        public string ObtenerRol(int id)
        {
            return _usuarioRepositorio.ObtenerRol(id);
        }
       
    }
}
