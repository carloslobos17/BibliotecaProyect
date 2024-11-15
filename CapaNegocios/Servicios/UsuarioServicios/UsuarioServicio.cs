using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Repositorios.UsuarioRepositorios;
using CapaEntidad.Entidades;
using Microsoft.Identity.Client;

namespace CapaNegocios.Servicios.UsuarioServicios
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioServicio(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public Usuario? Inicio(string correo, string clave)
        {
            return _usuarioRepositorio.ObtenerUsuarioPorCorreoyClave(correo, clave);
        }
    }
}
