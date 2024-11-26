using System;
using System.Collections.Generic;
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
        public int ObtenerIdPrestamo(int IdUsuario, int IdLibro)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT TOP 1 Id 
                                    FROM PRESTAMOS 
                                    WHERE IdUsuario = @IdUsuario AND IdLibro = @IdLibro
                                    ORDER BY Id DESC";

                int idPrestamo = conexion.QuerySingleOrDefault<int>(consulta, new { IdUsuario, IdLibro });

                return idPrestamo;
            }
        }

        public void AgregarDevolucion(Devolucion devolucion, int idLibro, bool estado)
        {
            using (var conexion = _dbConexion.GetConnection())
            {

                conexion.Open();
                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        AgregarDevolucionEnBD(devolucion);
                        ActualizarCantidadLibros(idLibro);
                        CambiarEstadoPrestamo(estado, idLibro);
                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        private void AgregarDevolucionEnBD(Devolucion devolucion)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"INSERT INTO Devoluciones(FechaDevolucion, Observaciones, IdPrestamo)
                     VALUES(@FechaDevolucion, @Observaciones, @IdPrestamo)";

                conexion.Query<Devolucion>(consulta, new
                {
                    devolucion.FechaDevolucion,
                    devolucion.Observaciones,
                    devolucion.IdPrestamo
                });
            }
        }


        private void ActualizarCantidadLibros(int idLibro)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string actualizarCantidad = @"UPDATE Libros
                                        SET CopiasDisponibles = CopiasDisponibles + 1
                                        WHERE Id = @IdLibro ";

                conexion.Query(actualizarCantidad, new { IdLibro = idLibro});
            }
        }

        private void CambiarEstadoPrestamo(bool activo, int idLibro) 
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"UPDATE Prestamos
                                 SET Activo = @Activo WHERE IdLibro = @IdLibro";

                conexion.Query(consulta , new { Activo = activo, IdLibro = idLibro });
            }
        }

        public IEnumerable<Usuario> ObtenerEstudiantes()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT u.nombre, u.Id FROM Usuarios u INNER JOIN Rol r ON u.IdRol = r.Id WHERE r.Id = @IdRol";

                return conexion.Query<Usuario>(consulta, new { IdRol = (int)RolEnum.Estudiante });
            }
        }

        public IEnumerable<Libro> ObtenerLibros()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT Titulo, Id FROM Libros";

                return conexion.Query<Libro>(consulta);
            }
        }
    }
}
