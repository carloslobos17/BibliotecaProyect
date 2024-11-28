using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
using Microsoft.Data.SqlClient;
using Dapper;

namespace CapaAccesoDatos.Repositorios.LibroRepositorios
{
    public class LibroRepositorio : ILibroRepositorio
    {
        private readonly IAccesoDatosSql _dbConexion;

        public LibroRepositorio(IAccesoDatosSql dbConexion)
        {
            _dbConexion = dbConexion;
        }

        public IEnumerable<Libro> ObtenerLibros()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT l.Id, 
                                           l.Titulo, 
                                           l.Autor,
                                           l.FechaPublicacion, 
                                           l.CopiasDisponibles, 
                                           c.Nombre 
                                    FROM Libros AS l INNER JOIN Categoria AS c ON l.IdCategoria = c.Id";

                return conexion.Query<Libro>(consulta);
            }
        }

        public IEnumerable<Categoria> ObtenerCategorias()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT * FROM Categoria";

                return conexion.Query<Categoria>(consulta);
            }
        }

        public void AgregarLibro(Libro libro)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"INSERT INTO Libros(Titulo, Autor, FechaPublicacion, CopiasDisponibles,IdCategoria) 
                                 VALUES(@Titulo, @Autor, @FechaPublicacion, @CopiasDisponibles,@IdCategoria)";

                conexion.Query<Libro>(consulta, new
                {
                    libro.Titulo,
                    libro.Autor,
                    libro.FechaPublicacion,
                    libro.CopiasDisponibles,
                    libro.IdCategoria
                });
            }
        }

        public void EditarLibro(Libro libro)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"UPDATE Libros SET
                                 Titulo = @Titulo,
                                 Autor = @Autor,
                                 FechaPublicacion = @FechaPublicacion,
                                 CopiasDisponibles = @CopiasDisponibles
                                 WHERE Id = @Id";

                conexion.Query<Libro>(consulta, libro);
            }
        }

        public void EliminarLibro(int id)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = "DELETE FROM Libros WHERE Id = @Id";

                conexion.Query<Libro>(consulta, new { id });
            }
        }
    }
}
