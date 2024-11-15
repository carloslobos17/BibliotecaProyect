using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.BibliotecarioServicios
{
    public interface IBibliotecarioServicio
    {
        void AgregarBibliotecario(Usuario usuario);
        void EditarBibliotecario(Usuario usuario);
        void EliminarBibliotecario(int id);
        IEnumerable<Usuario> GetAllLibros();
    }
}