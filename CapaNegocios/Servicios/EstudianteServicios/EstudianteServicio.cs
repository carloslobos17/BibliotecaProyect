using CapaAccesoDatos.Repositorios.EstudianteRepositorios;
using CapaAccesoDatos.Repositorios.GestionUsuarioRepositorios;
using CapaEntidad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Servicios.EstudianteServicios
{
    public class EstudianteServicio : IEstudianteServicio
    {
        private readonly IEstudianteRepositorio _estudianteRepositorio;

        public EstudianteServicio(IEstudianteRepositorio estudianteRepositorio)
        {
            _estudianteRepositorio = estudianteRepositorio;
        }

        public IEnumerable<Usuario> ObtenerEstudiantes() => _estudianteRepositorio.ObtenerEstudiante();

        public void AgregarEstudiante(Usuario usuario) => _estudianteRepositorio.AgregarEstudiante(usuario);

        public void EditarEstudiante(Usuario usuario) => _estudianteRepositorio.EditarEstudiante(usuario);

        public void EliminarEstudiante(int id) => _estudianteRepositorio.EliminarEstudiante(id);
    }
}
