using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.DevolucionRepositorios
{
    public interface IDevolucionRepositorio
    {
        IEnumerable<Prestamo> BuscarPrestamos(string nombreUsuario);
        IEnumerable<Prestamo> ObtenerPrestamos();

        public void DevolverLibro(int idLibro, bool activo, Devolucion devolucion);
    }
}