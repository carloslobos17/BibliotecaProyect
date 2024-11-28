using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
using CapaEntidad.Enums;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Repositorios.EstudianteRepositorios
{
    public class EstudianteRepositorio : IEstudianteRepositorio
    {

        private readonly IAccesoDatosSql _dbConexion;

        public EstudianteRepositorio(IAccesoDatosSql dbConexion)
        {
            _dbConexion = dbConexion;
        }

        public IEnumerable<Usuario> ObtenerEstudiante()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT u.nombre, u.Id FROM Usuarios u INNER JOIN Rol r ON u.IdRol = r.Id WHERE r.Id = @IdRol";

                return conexion.Query<Usuario>(consulta, new { IdRol = (int)RolEnum.Estudiante });
            }
        }

        public void AgregarEstudiante(Usuario usuario)
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

        public void EditarEstudiante(Usuario usuario)
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

        public void EliminarEstudiante(int id)
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = "DELETE FROM Usuarios WHERE Id = @Id";

                conexion.Query<Usuario>(consulta, new { id });
            }
        }
    }
}
