using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.LibroRepositorios
{
    public interface ILibroRepositorio
    {
        void AgregarLibro(Libro libro);
        void EditarLibro(Libro libro);
        void EliminarLibro(int id);
        IEnumerable<Libro> ObtenerLibros();

        IEnumerable<Categoria> ObtenerCategorias();
        IEnumerable<Libro> ObtenerLibrosFiltrado(DateTime iniciarDato, DateTime finalizarDato);
    }
}
