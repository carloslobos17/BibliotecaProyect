using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.PanelServicios
{
    public interface IPanelServicio
    {
        int BibliotecariosRegistrados();
        int CantidadDevoluciones();
        int CantidadLibros();
        int CantidadPrestamos();
        IEnumerable<EstadisticaCategoria> ObtenerCantidadCategorias();
        IEnumerable<EstadisticaPrestamo> ObtenerLibrosMasPrestados();
    }
}