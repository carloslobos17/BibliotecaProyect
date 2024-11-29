using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.HistorialRepositorios
{
    public interface IHistorialRepositorio
    {
        IEnumerable<Devolucion> ObtenerDevoluciones(int IdUsuario);
        IEnumerable<Prestamo> ObtenerPrestamos(int IdUsuario);
    }
}