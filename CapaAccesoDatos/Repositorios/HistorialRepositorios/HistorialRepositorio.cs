using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
using Dapper;

namespace CapaAccesoDatos.Repositorios.HistorialRepositorios
{
    public class HistorialRepositorio : IHistorialRepositorio
    {
        readonly IAccesoDatosSql _dbConexion;

        public HistorialRepositorio(IAccesoDatosSql dbConexion)
        {
            _dbConexion = dbConexion;
        }
        public IEnumerable<Prestamo> ObtenerPrestamos(int IdUsuario)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT 
                                    p.id, 
                                    p.FechaPrestamo, 
                                    p.FechaDevolucion, 
                                    p.Activo, 
                                    l.Titulo AS TituloLibro
                                FROM Prestamos p 
                                INNER JOIN Libros l 
                                ON p.IdLibro = l.Id 
                                WHERE IdUsuario = @IdUsuario";

                return conexion.Query<Prestamo>(consulta, new {IdUsuario});
            }
        }

        public IEnumerable<Devolucion> ObtenerDevoluciones(int IdUsuario)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT 
                                        d.Id, 
                                        d.FechaDevolucion, 
                                        d.Observaciones, 
                                        l.Titulo AS TituloLibro,
                                        d.IdPrestamo
                                    FROM Devoluciones d 
                                    INNER JOIN Prestamos p ON d.IdPrestamo = p.Id 
                                    INNER JOIN Libros l ON p.IdLibro = l.Id
                                    WHERE p.IdUsuario = @IdUsuario";
                return conexion.Query<Devolucion>(consulta, new { IdUsuario });
            }
        }

    }
}
