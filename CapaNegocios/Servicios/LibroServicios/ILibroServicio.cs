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
        void AgregarLibro(Libro libro);
        void EliminarLibro(int id);
        void EditarLibro(Libro libro);
        IEnumerable<Libro> ObtenerLibros();
        IEnumerable<Categoria> ObtenerCategorias();
        IEnumerable<Libro> ObtenerLibrosFiltrado(DateTime iniciarDato, DateTime finalizarDato);
    }
}
