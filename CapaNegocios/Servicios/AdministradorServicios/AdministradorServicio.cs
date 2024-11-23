using CapaAccesoDatos.Repositorios.AdministradorRepositorios;
using CapaEntidad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Servicios.AdministradorServicios
{
    public class AdministradorServicio : IAdministradorServicio
    {
        private readonly IAdministradorRepositorio _administradorRepositorio;

        public AdministradorServicio(IAdministradorRepositorio administradorRepositorio)
        {
            _administradorRepositorio = administradorRepositorio;
        }

        public IEnumerable<Usuario> ObtenerAdministrador() => _administradorRepositorio.ObtenerAdministrador();

        public void AgregarAdministrador(Usuario usuario) => _administradorRepositorio.AgregarAdministrador(usuario);

        public void EditarAdministrador(Usuario usuario) => _administradorRepositorio.EditarAdministrador(usuario);

        public void EliminarAdministrador(int id) => _administradorRepositorio.EliminarAdministrador(id);
    }
}
