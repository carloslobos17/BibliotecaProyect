using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.BibliotecarioRepositorios
{
    public interface IBibliotecarioRepositorio
    {
        void AgregarBibliotecario(Usuario usuario);
        void EditarBibliotecario(Usuario usuario);
        void EliminarBibliotecario(int id);
        IEnumerable<Usuario> ObtenerBibliotecario();
    }
}