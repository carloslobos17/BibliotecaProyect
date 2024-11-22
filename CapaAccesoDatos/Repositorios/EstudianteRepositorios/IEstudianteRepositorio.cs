using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.EstudianteRepositorios
{
    public interface IEstudianteRepositorio
    {
        void AgregarEstudiante(Usuario usuario);
        void EditarEstudiante(Usuario usuario);
        void EliminarEstudiante(int id);
        IEnumerable<Usuario> ObtenerEstudiante();
    }
}