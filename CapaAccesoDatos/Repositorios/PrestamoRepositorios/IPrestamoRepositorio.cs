using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.PrestamoRepositorios
{
    public interface IPrestamoRepositorio
    {
        void AgregarPrestamo(Prestamo prestamo);
        IEnumerable<Usuario> ObtenerEstudiantes();

        IEnumerable<Libro> ObtenerLibros();
    }
}