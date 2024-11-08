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

        public IEnumerable<Libro> GetAllLibros() => _libroRepositorio.GetLibros();

        public void AddLibro(Libro libro) => _libroRepositorio.AddLibro(libro);

        public void EditLibro(Libro libro) => _libroRepositorio.EditLibro(libro);

        public void DeleteLibro(int id) => _libroRepositorio.DeleteLibro(id);
        }
    }

