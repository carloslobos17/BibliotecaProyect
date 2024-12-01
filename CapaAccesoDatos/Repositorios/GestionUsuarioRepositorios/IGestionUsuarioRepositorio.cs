using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.GestionUsuarioRepositorios
{
    public interface IGestionUsuarioRepositorio
    {
        void AgregarUsuario(Usuario usuario);
        void EditarUsuario(Usuario usuario);
        void EliminarUsuario(int id);
        IEnumerable<Usuario> ObtenerAdminFiltrados();
        IEnumerable<Usuario> ObtenerAdministrador();
        IEnumerable<Usuario> ObtenerBibliotecarios();
        IEnumerable<Usuario> ObtenerBibliotecariosFiltrados();
        IEnumerable<Usuario> ObtenerEstudiantes();
        IEnumerable<Usuario> ObtenerUsuariosFiltrados();
    }
}