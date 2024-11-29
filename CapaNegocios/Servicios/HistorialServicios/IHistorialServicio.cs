using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.HistorialServicios
{
    public interface IHistorialServicio
    {
        IEnumerable<Devolucion> ObtenerDevoluciones(int IdUsuario);
        IEnumerable<Prestamo> ObtenerPrestamos(int IdUsuario);
    }
}