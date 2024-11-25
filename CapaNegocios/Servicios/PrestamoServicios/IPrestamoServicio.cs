using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.PrestamoServicios
{
    public interface IPrestamoServicio
    {
        void AgregarPrestamo(Prestamo prestamo);

        IEnumerable<Usuario> ObtenerEstudiantes();
        IEnumerable<Libro> ObtenerLibros();
    }
}