using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Repositorios.DevolucionRepositorios;
using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.DevolucionServicios
{
    public class DevolucionServicio : IDevolucionServicio
    {
        private readonly IDevolucionRepositorio _devolucionRepositorio;

        public DevolucionServicio(IDevolucionRepositorio devolucionRepositorio)
        {
            _devolucionRepositorio = devolucionRepositorio;
        }

        public int ObtenerIdPrestamo(int idEstudiante, int idLibro) => _devolucionRepositorio.ObtenerIdPrestamo(idEstudiante, idLibro);
        public void AgregarDevolucion(Devolucion devolucion, int IdLibro, bool estado) => _devolucionRepositorio.AgregarDevolucion(devolucion, IdLibro, estado);
        public IEnumerable<Usuario> ObtenerEstudiantes() => _devolucionRepositorio.ObtenerEstudiantes();
        public IEnumerable<Libro> ObtenerLibros() => _devolucionRepositorio.ObtenerLibros();
    }
}
