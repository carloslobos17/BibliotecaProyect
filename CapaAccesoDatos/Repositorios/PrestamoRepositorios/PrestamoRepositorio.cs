using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
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
                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string consultaPrestamo = @"INSERT INTO Prestamos(FechaPrestamo, FechaDevolucion, IdUsuario, IdLibro, Activo)
                                            VALUES(@FechaPrestamo, @FechaDevolucion, @IdUsuario, @IdLibro, @Activo)";

                        conexion.Execute(consultaPrestamo, new
                        {
                            prestamo.FechaPrestamo,
                            prestamo.FechaDevolucion,
                            prestamo.IdUsuario,
                            prestamo.IdLibro,
                            prestamo.Activo
                        }, transaccion);

                        string actualizarCantidad = @"UPDATE Libros
                                              SET CopiasDisponibles = CopiasDisponibles - 1
                                              WHERE IdLibro = @IdLibro AND CopiasDisponibles > 0";

                        int filasAfectadas = conexion.Execute(actualizarCantidad, new
                        {
                            IdLibro = prestamo.IdLibro
                        }, transaccion);

                        if (filasAfectadas == 0)
                        {
                            throw new InvalidOperationException("No hay copias disponibles para este libro.");
                        }

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


    }
}
