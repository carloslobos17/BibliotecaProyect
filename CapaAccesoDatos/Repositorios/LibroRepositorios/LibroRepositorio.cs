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
        private readonly IAccesoDatosSql _dbConnection;

        public LibroRepositorio(IAccesoDatosSql dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Libro> GetLibro()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    l.Id, 
                                    l.Titulo,
                                    l.FechaPublicacion,
                                    l.CopiasDisponibles,
                                    c.IdCategoria AS Categoria
                                FROM Libros AS l 
                                INNER JOIN Categpria AS c ON l.IdCategoria = c.Id";

                return connection.Query<Libro>(query);
            }
        }

        public void AddLibro(Libro libro)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Libros(Titulo, FechaPublicacion, CopiasDisponibles,IdCategoria) 
                                 VALUES(@Titulo, @FechaPublicacion, @CopiasDisponibles,@IdCategoria)";

                connection.Query<Libro>(query, new { libro.Titulo});
                connection.Query<Libro>(query, new { libro.FechaPublicacion });
                connection.Query<Libro>(query, new { libro.CopiasDisponibles });
                connection.Query<Libro>(query, new { libro.IdCategoria});
            }
        }

        public void EditLibro(Libro libro)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Libros SET
                                 Titulo = @Titulo,
                                 FechaPublicacion,
                                 CopiasDisponibles,
                                 WHERE Id = @Id";

                connection.Query<Libro>(query, libro);
            }
        }

        public void DeleteLibro(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Libros WHERE Id = @Id";

                connection.Query<Libro>(query, new { id });
            }
        }

        public IEnumerable<Libro> GetLibros()
        {
            throw new NotImplementedException();
        }
    }
}
