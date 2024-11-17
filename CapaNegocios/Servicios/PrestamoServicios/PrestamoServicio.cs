using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Repositorios.CategoriasRepositorios;
using CapaAccesoDatos.Repositorios.PrestamoRepositorios;
using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.PrestamoServicios
{
    public class PrestamoServicio : IPrestamoServicio
    {
        private readonly IPrestamoRepositorio _prestamoRepositorio;

        public PrestamoServicio(IPrestamoRepositorio prestamoRepositorio)
        {
            _prestamoRepositorio = prestamoRepositorio;
        }

        public void AgregarPrestamo(Prestamo prestamo) => _prestamoRepositorio.AgregarPrestamo(prestamo);
    }
}
