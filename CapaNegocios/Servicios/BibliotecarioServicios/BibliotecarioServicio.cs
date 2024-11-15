using CapaAccesoDatos.Repositorios.BibliotecarioRepositorios;
using CapaAccesoDatos.Repositorios.LibroRepositorios;
using CapaEntidad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Servicios.BibliotecarioServicios
{
    public class BibliotecarioServicio : IBibliotecarioServicio
    {
        private readonly IBibliotecarioRepositorio _bibliotecarioRepositorio;

        public BibliotecarioServicio(IBibliotecarioRepositorio bibliotecarioRepositorio)
        {
            _bibliotecarioRepositorio = bibliotecarioRepositorio;
        }

        public IEnumerable<Usuario> GetAllLibros() => _bibliotecarioRepositorio.ObtenerBibliotecario();

        public void AgregarBibliotecario(Usuario usuario) => _bibliotecarioRepositorio.AgregarBibliotecario(usuario);

        public void EditarBibliotecario(Usuario usuario) => _bibliotecarioRepositorio.EditarBibliotecario(usuario);

        public void EliminarBibliotecario(int id) => _bibliotecarioRepositorio.EliminarBibliotecario(id);
    }
}

