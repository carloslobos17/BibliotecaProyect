using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Repositorios.CategoriasRepositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly IAccesoDatosSql _dbConexion;

        public CategoriaRepositorio(IAccesoDatosSql dbConexion)
        {
            _dbConexion = dbConexion;
        }

        public IEnumerable<Categoria> ObtenerCategorias()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT Id, Nombre
                            FROM Categoria";

                return conexion.Query<Categoria>(consulta);
            }
        }

        public void AgregarCategoria(Categoria categoria)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"INSERT INTO Categoria(Nombre) 
                                 VALUES(@Nombre)";

                conexion.Query<Categoria>(consulta, new { categoria.Nombre });

            }

        }
        public void EditarCategoria(Categoria categoria)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"UPDATE Categoria SET
                                 Nombre = @Nombre,
                                 WHERE Id = @Id";

                conexion.Query<Categoria>(consulta, categoria);
            }
        }

        public void EliminarCategoria(int id)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = "DELETE FROM Categoria WHERE Id = @Id";

                conexion.Query<Categoria>(consulta, new { id });
            }
        }

    }
}
