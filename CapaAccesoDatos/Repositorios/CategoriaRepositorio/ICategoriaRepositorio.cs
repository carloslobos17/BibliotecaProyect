using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.CategoriasRepositorios
{
    public interface ICategoriaRepositorio
    {
        void AgregarCategoria(Categoria categoria);
        void EditarCategoria(Categoria categoria);
        void EliminarCategoria(int id);
        IEnumerable<Categoria> ObtenerCategorias();
    }
}