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
        void AddLibro(Libro libro);
        void EditLibro(Libro libro);
        void DeleteLibro(int id);
        IEnumerable<Libro> GetLibros();
    }
}
