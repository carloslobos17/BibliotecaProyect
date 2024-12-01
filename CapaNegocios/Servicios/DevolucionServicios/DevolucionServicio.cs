using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Repositorios.DevolucionRepositorios;
using CapaEntidad.Entidades;
using Org.BouncyCastle.Asn1.Ess;

namespace CapaNegocios.Servicios.DevolucionServicios
{
    public class DevolucionServicio : IDevolucionServicio
    {
        private readonly IDevolucionRepositorio _devolucionRepositorio;

        public DevolucionServicio(IDevolucionRepositorio devolucionRepositorio)
        {
            _devolucionRepositorio = devolucionRepositorio;
        }

        
        public IEnumerable<Prestamo> ObtenerPrestamos() => _devolucionRepositorio.ObtenerPrestamos();
        public IEnumerable<Prestamo> BuscarPrestamos(string nombreUsuario) => _devolucionRepositorio.BuscarPrestamos(nombreUsuario);

        public void DevolverLibro(int idLibro, bool activo, Devolucion devolucion) => _devolucionRepositorio.DevolverLibro(idLibro, activo, devolucion);
    }
}
