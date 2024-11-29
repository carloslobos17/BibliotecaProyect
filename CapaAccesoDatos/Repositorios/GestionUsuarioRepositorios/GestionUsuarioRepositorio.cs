using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
using CapaEntidad.Enums;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Repositorios.GestionUsuarioRepositorios
{
    public class GestionUsuarioRepositorio : IGestionUsuarioRepositorio
    {
        private readonly IAccesoDatosSql _dbConexion;

        public GestionUsuarioRepositorio(IAccesoDatosSql dbConexion)
        {
            _dbConexion = dbConexion;
        }

        public IEnumerable<Usuario> ObtenerAdministrador()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT u.nombre, u.Id, u.apellido, u.edad, u.clave, u.telefono, u.correo, u.IdRol FROM Usuarios u INNER JOIN Rol r ON u.IdRol = r.Id WHERE r.Id = @IdRol";

                return conexion.Query<Usuario>(consulta, new { IdRol = (int)RolEnum.Admin });
            }
        }

        public IEnumerable<Usuario> ObtenerBibliotecarios()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT u.nombre, u.Id, u.apellido, u.edad, u.clave, u.telefono, u.correo, u.IdRol FROM Usuarios u INNER JOIN Rol r ON u.IdRol = r.Id WHERE r.Id = @IdRol";

                return conexion.Query<Usuario>(consulta, new { IdRol = (int)RolEnum.Bibliotecario });
            }
        }

        public IEnumerable<Usuario> ObtenerEstudiantes()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT u.nombre, u.Id, u.apellido, u.edad, u.clave, u.telefono, u.correo, u.IdRol FROM Usuarios u INNER JOIN Rol r ON u.IdRol = r.Id WHERE r.Id = @IdRol";

                return conexion.Query<Usuario>(consulta, new { IdRol = (int)RolEnum.Estudiante });
            }
        }

        public void AgregarUsuario(Usuario usuario)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"INSERT INTO Usuarios(Nombre, Apellido, Edad, Clave, Telefono, Correo, IdRol)
                                    VALUES(@Nombre, @Apellido, @Edad, @Clave, @Telefono, @Correo, @IdRol)";

                conexion.Query<Usuario>(consulta, new
                {
                    usuario.Nombre,
                    usuario.Apellido,
                    usuario.Edad,
                    usuario.Clave,
                    usuario.Telefono,
                    usuario.Correo,
                    usuario.IdRol
                });
            }
        }

        public void EditarUsuario(Usuario usuario)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"UPDATE Usuarios SET
                                    Nombre = @Nombre,
                                    Apellido = @Apellido,
                                    Edad = @Edad,
                                    Clave = @Clave,
                                    Telefono = @Telefono,
                                    Correo = @Correo
                                    WHERE Id = @Id";

                conexion.Query<Usuario>(consulta, usuario);
            }
        }

        public void EliminarUsuario(int id)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = "DELETE FROM Usuarios WHERE Id = @Id";

                conexion.Query<Usuario>(consulta, new { id });
            }
        }
    }
}