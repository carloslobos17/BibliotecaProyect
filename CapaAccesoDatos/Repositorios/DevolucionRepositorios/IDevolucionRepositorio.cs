using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.DevolucionRepositorios
{
    public interface IDevolucionRepositorio
    {
        void AgregarDevolucion(Devolucion devolucion, int idLibro, bool estado);
        IEnumerable<Usuario> ObtenerEstudiantes();
        int ObtenerIdPrestamo(int idEstudiante, int IdLibro);
        IEnumerable<Libro> ObtenerLibros();
    }
}