using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.GestionUsuarioServicios
{
    public interface IGestionUsuarioServicio
    {
        void AgregarUsuario(Usuario usuario);
        void EditarUsuario(Usuario usuario);
        void EliminarUsuario(int id);
        IEnumerable<Usuario> ObtenerBibliotecarios();
        IEnumerable<Usuario> ObtenerAdministrador();
        IEnumerable<Usuario> ObtenerEstudiantes();
        IEnumerable<Usuario> ObtenerUsuariosFiltrados();
        IEnumerable<Usuario> ObtenerAdminFiltrados();
        IEnumerable<Usuario> ObtenerBibliotecariosFiltrados();
    }
}