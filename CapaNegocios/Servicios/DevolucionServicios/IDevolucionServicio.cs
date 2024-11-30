using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.DevolucionServicios
{
    public interface IDevolucionServicio
    {
        IEnumerable<Prestamo> ObtenerPrestamos();
        IEnumerable<Prestamo> BuscarPrestamos(string nombreUsuario);

        public void DevolverLibro(int idLibro, bool activo, Devolucion devolucion);
    }
}