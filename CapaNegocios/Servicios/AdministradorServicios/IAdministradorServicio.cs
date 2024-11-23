using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.AdministradorServicios
{
    public interface IAdministradorServicio
    {
        void AgregarAdministrador(Usuario usuario);
        void EditarAdministrador(Usuario usuario);
        void EliminarAdministrador(int id);
        IEnumerable<Usuario> ObtenerAdministrador();
    }
}