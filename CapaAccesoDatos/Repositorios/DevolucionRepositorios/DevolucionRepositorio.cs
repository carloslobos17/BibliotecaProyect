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

namespace CapaAccesoDatos.Repositorios.DevolucionRepositorios
{
    public class DevolucionRepositorio : IDevolucionRepositorio
    {
        private readonly IAccesoDatosSql _dbConexion;
        public DevolucionRepositorio(IAccesoDatosSql dbConexion)
        {
            _dbConexion = dbConexion;
        }

        public IEnumerable<Prestamo> ObtenerPrestamos()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT 
                                        p.Id, 
                                        p.IdUsuario, 
                                        p.FechaPrestamo, 
                                        p.FechaDevolucion,
                                        l.Id AS IdLibro, 
                                        l.Titulo AS TituloLibro, 
                                        p.Activo
                                    FROM 
                                        Prestamos p
                                    INNER JOIN 
                                        Libros l ON p.IdLibro = l.Id
                                    INNER JOIN 
                                        Usuarios u ON p.IdUsuario = u.Id
                                    WHERE p.Activo = 1;
";

                return conexion.Query<Prestamo>(consulta);
            }
        }

        public IEnumerable<Prestamo> BuscarPrestamos(string nombreUsuario)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT 
                                        p.Id, 
                                        p.IdUsuario, 
                                        p.FechaPrestamo, 
                                        p.FechaDevolucion, 
                                        l.Id AS IdLibro, 
                                        l.Titulo AS TituloLibro, 
                                        p.Activo
                                    FROM 
                                        Prestamos p
                                    INNER JOIN 
                                        Libros l ON p.IdLibro = l.Id
                                    INNER JOIN 
                                        Usuarios u ON p.IdUsuario = u.Id
                                    WHERE 
                                        u.Nombre LIKE '%' + @nombreUsuario + '%' AND p.Activo = 1";

                return conexion.Query<Prestamo>(consulta, new { nombreUsuario });
            }
        }

        public void DevolverLibro(int idLibro, bool activo, Devolucion devolucion)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = "spDevolverLibro";

                var parametros = new
                {
                    IdLibro = idLibro,
                    Activo = activo,
                    FechaDevolucion = devolucion.FechaDevolucion,
                    Observaciones = devolucion.Observaciones,
                    IdPrestamo = devolucion.IdPrestamo
                };

                conexion.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
