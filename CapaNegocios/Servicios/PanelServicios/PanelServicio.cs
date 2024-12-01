using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Repositorios.PanelRepositorios;
using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.PanelServicios
{
    public class PanelServicio : IPanelServicio
    {
        private readonly IPanelRepositorio _panelRepositorio;

        public PanelServicio(IPanelRepositorio panelRepositorio)
        {
            _panelRepositorio = panelRepositorio;
        }

        public int BibliotecariosRegistrados() => _panelRepositorio.BibliotecariosRegistrados();
        public int CantidadDevoluciones() => _panelRepositorio.CantidadDevoluciones();
        public int CantidadLibros() => _panelRepositorio.CantidadLibros();
        public int CantidadPrestamos() => _panelRepositorio.CantidadLibros();
        public IEnumerable<EstadisticaCategoria> ObtenerCantidadCategorias() => _panelRepositorio.ObtenerCantidadCategorias();
        public IEnumerable<EstadisticaPrestamo> ObtenerLibrosMasPrestados() => _panelRepositorio.ObtenerLibrosMasPrestados();
    }
}
