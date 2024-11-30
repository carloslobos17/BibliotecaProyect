using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Repositorios;
using CapaAccesoDatos.Repositorios.LibroRepositorios;
using CapaEntidad.Entidades;
using CapaNegocios.Servicios.LibroServicios;

namespace CapaNegocios.Servicios.LibroServicios
{
    public class LibroServicio : ILibroServicio
    {
        private readonly ILibroRepositorio _libroRepositorio;

        public LibroServicio(ILibroRepositorio libroRepositorio)
        {
            _libroRepositorio = libroRepositorio;
        }

        public IEnumerable<Libro> ObtenerLibros() => _libroRepositorio.ObtenerLibros();

        public IEnumerable<Categoria> ObtenerCategorias() => _libroRepositorio.ObtenerCategorias();

        public void AgregarLibro(Libro libro) => _libroRepositorio.AgregarLibro(libro);

        public void EditarLibro(Libro libro) => _libroRepositorio.EditarLibro(libro);

        public void EliminarLibro(int id) => _libroRepositorio.EliminarLibro(id);

        public IEnumerable<Libro> ObtenerLibrosFiltrado(DateTime iniciarDato, DateTime finalizarDato)
            => _libroRepositorio.ObtenerLibrosFiltrado(iniciarDato, finalizarDato);
        }
    }

