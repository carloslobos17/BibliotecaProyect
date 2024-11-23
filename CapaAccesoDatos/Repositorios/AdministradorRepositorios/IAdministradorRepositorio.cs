using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.AdministradorRepositorios
{
    public interface IAdministradorRepositorio
    {
        void AgregarAdministrador(Usuario usuario);
        void EditarAdministrador(Usuario usuario);
        void EliminarAdministrador(int id);
        IEnumerable<Usuario> ObtenerAdministrador();
    }
}