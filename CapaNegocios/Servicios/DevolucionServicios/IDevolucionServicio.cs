using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.DevolucionServicios
{
    public interface IDevolucionServicio
    {
        void AgregarDevolucion(Devolucion devolucion, int IdLibro, bool estado);
        IEnumerable<Usuario> ObtenerEstudiantes();
        int ObtenerIdPrestamo(int idEstudiante, int idLibro);
        IEnumerable<Libro> ObtenerLibros();
    }
}