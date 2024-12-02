using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
using CapaEntidad.Enums;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos.Repositorios.PanelRepositorios
{
    public class PanelRepositorio : IPanelRepositorio
    {
        private readonly IAccesoDatosSql _dbConexion;

        public PanelRepositorio(IAccesoDatosSql dbConexion)
        {
            _dbConexion = dbConexion;
        }

        public int BibliotecariosRegistrados()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT Count(*) 
                                    AS TotalBibliotecarios 
                                    FROM Usuarios 
                                    WHERE IdRol = @IdRol";

                return conexion.QuerySingle<int>(consulta, new { IdRol = (int)RolEnum.Bibliotecario });
            }
        }

        public int CantidadLibros()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT Count(*) AS TotalLibros FROM Libros";

                return conexion.QuerySingle<int>(consulta);
            }
        }

        public int CantidadPrestamos()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT Count(*) AS TotalPrestamos FROM Prestamos";

                return conexion.QuerySingle<int>(consulta);
            }
        }

        public int CantidadDevoluciones()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT Count(*) AS TotalDevoluciones FROM Devoluciones";

                return conexion.QuerySingle<int>(consulta);
            }
        }

        public IEnumerable<EstadisticaPrestamo> ObtenerLibrosMasPrestados()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT TOP 10
                                        l.Titulo AS Libro, 
                                        COUNT(p.IdLibro) AS Cantidad
                                    FROM Prestamos p
                                    INNER JOIN Libros l 
                                    ON p.IdLibro = l.Id
                                    GROUP BY l.Titulo
                                    ORDER BY Cantidad DESC";

                return conexion.Query<EstadisticaPrestamo>(consulta);
            }
        }

        public IEnumerable<EstadisticaCategoria> ObtenerCantidadCategorias()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT TOP 5
	                                    c.Nombre As Categoria,
	                                    Count(l.IdCategoria) As Cantidad
                                    FROM Libros l
                                    INNER JOIN Categoria c
                                    ON l.IdCategoria = c.Id
                                    GROUP BY c.Nombre
                                    ORDER BY Cantidad DESC";

                return conexion.Query<EstadisticaCategoria>(consulta);
            }
        }





    }
}
