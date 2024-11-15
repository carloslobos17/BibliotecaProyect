using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.CategoriaServicios
{
    public interface ICategoriaServicios
    {
        void AgregarCategoria(Categoria categoria);
        void EditarCategoria(Categoria categoria);
        void EliminarCategoria(int id);
        IEnumerable<Categoria> ObtenerCategorias();
    }
}