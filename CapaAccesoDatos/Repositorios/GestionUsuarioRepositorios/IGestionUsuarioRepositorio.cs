using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.GestionUsuarioRepositorios
{
    public interface IGestionUsuarioRepositorio
    {
        void AgregarUsuario(Usuario usuario);
        void EditarUsuario(Usuario usuario);
        void EliminarUsuario(int id);
        IEnumerable<Usuario> ObtenerUsuario();
    }
}