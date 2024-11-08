using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.LibroServicios
{
    public interface ILibroServicio
    {
            
        void AddLibro(Libro libro);
        void DeleteLibro(int id);
        void EditLibro(Libro libro);
        IEnumerable<Libro> GetAllLibros();
    }
}
