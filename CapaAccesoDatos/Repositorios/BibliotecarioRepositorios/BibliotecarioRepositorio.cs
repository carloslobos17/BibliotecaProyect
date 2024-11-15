using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
using Dapper;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Repositorios.BibliotecarioRepositorios
{
    public class BibliotecarioRepositorio : IBibliotecarioRepositorio
    {
        private readonly IAccesoDatosSql _dbConexion;

        public BibliotecarioRepositorio(IAccesoDatosSql dbConexion)
        {
            _dbConexion = dbConexion;
        }

        public IEnumerable<Usuario> ObtenerBibliotecario()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT 
                                    Id,
                                    Nombre,
                                    Apellido,
                                    Correo
                                FROM Usuarios";

                return conexion.Query<Usuario>(consulta);
            }
        }

        public void AgregarBibliotecario(Usuario usuario)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"INSERT INTO Usuarios(Nombre, Apellido, Correo) 
                                 VALUES(@Nombre, @Apellido, @Correo)";

                conexion.Query<Usuario>(consulta, new { usuario.Nombre });
                conexion.Query<Usuario>(consulta, new { usuario.Apellido });
                conexion.Query<Usuario>(consulta, new { usuario.Correo });
            }
        }

        public void EditarBibliotecario(Usuario usuario)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"UPDATE Usuarios SET
                                 Nombre = @Nombre,
                                 Apelliod = @Apellido,
                                 Correo = @Correo,
                                 WHERE Id = @Id";

                conexion.Query<Usuario>(consulta, usuario);
            }
        }

        public void EliminarBibliotecario(int id)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = "DELETE FROM Usuarios WHERE Id = @Id";

                conexion.Query<Usuario>(consulta, new { id });
            }
        }


    }
}
