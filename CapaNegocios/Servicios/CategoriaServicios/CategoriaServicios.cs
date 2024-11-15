using CapaAccesoDatos.Repositorios.CategoriasRepositorios;
using CapaAccesoDatos.Repositorios.LibroRepositorios;
using CapaEntidad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Servicios.CategoriaServicios
{
    public class CategoriaServicios : ICategoriaServicios
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaServicios(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public IEnumerable<Categoria> ObtenerCategorias() => _categoriaRepositorio.ObtenerCategorias();

        public void AgregarCategoria(Categoria categoria) => _categoriaRepositorio.AgregarCategoria(categoria);

        public void EditarCategoria(Categoria categoria) => _categoriaRepositorio.EditarCategoria(categoria);

        public void EliminarCategoria(int id) => _categoriaRepositorio.EliminarCategoria(id);
    }
}

