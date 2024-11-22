using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.EstudianteServicios
{
    public interface IEstudianteServicio
    {
        void AgregarEstudiante(Usuario usuario);
        void EditarEstudiante(Usuario usuario);
        void EliminarEstudiante(int id);
        IEnumerable<Usuario> ObtenerEstudiantes();
    }
}