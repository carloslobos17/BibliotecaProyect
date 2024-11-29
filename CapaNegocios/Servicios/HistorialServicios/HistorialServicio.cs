using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Repositorios.HistorialRepositorios;
using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.HistorialServicios
{
    public class HistorialServicio : IHistorialServicio
    {
        private readonly IHistorialRepositorio _historialRepositorio;

        public HistorialServicio(IHistorialRepositorio historialRepositorio)
        {
            _historialRepositorio = historialRepositorio;
        }

        public IEnumerable<Prestamo> ObtenerPrestamo(int IdUsuario) => _historialRepositorio.ObtenerPrestamos(IdUsuario);

        public IEnumerable<Devolucion> ObtenerDevoluciones(int IdUsuario) => _historialRepositorio.ObtenerDevoluciones(IdUsuario);


    }
}
