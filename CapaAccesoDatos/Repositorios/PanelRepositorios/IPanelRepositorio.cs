using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.PanelRepositorios
{
    public interface IPanelRepositorio
    {
        int BibliotecariosRegistrados();
        int CantidadDevoluciones();
        int CantidadLibros();
        int CantidadPrestamos();
        IEnumerable<EstadisticaCategoria> ObtenerCantidadCategorias();
        IEnumerable<EstadisticaPrestamo> ObtenerLibrosMasPrestados();
    }
}