using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
using CapaEntidad.Enums;
using Dapper;

namespace CapaAccesoDatos.Repositorios.PrestamoRepositorios
{
    public class PrestamoRepositorio : IPrestamoRepositorio
    {
        private readonly IAccesoDatosSql _dbConexion;

        public PrestamoRepositorio(IAccesoDatosSql dbConexion)
        {
            _dbConexion = dbConexion;
        }

        public void AgregarPrestamo(Prestamo prestamo)
        {
            using (var conexion = _dbConexion.GetConnection())
            {

                conexion.Open();
                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        AgregarPrestamoEnBD(prestamo);
                        ActualizarCantidadLibros(prestamo);
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

        public void AgregarPrestamoEnBD(Prestamo prestamo)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consultaPrestamo = @"INSERT INTO Prestamos(FechaPrestamo, FechaDevolucion, IdUsuario, IdLibro, Activo)
                     VALUES(@FechaPrestamo, @FechaDevolucion, @IdUsuario, @IdLibro, @Activo)";

                conexion.Query<Prestamo>(consultaPrestamo, new
                {
                    prestamo.FechaPrestamo,
                    prestamo.FechaDevolucion,
                    prestamo.IdUsuario,
                    prestamo.IdLibro,
                    prestamo.Activo
                });
            }
        }

        public void ActualizarCantidadLibros(Prestamo prestamo)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string actualizarCantidad = @"UPDATE Libros
                                        SET CopiasDisponibles = CopiasDisponibles - 1
                                        WHERE Id = @IdLibro AND CopiasDisponibles > 0";

                conexion.Query<Prestamo>(actualizarCantidad, new
                {
                    prestamo.IdLibro
                });
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
