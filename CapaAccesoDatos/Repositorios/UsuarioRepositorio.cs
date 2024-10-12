using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos.Repositorios
{
    public class UsuarioRepositorio
    {
        private AccesoDatosSql _bdConexion;

        public UsuarioRepositorio()
        {
            _bdConexion = new AccesoDatosSql();
        }

        public string ObtenerRol(int Id)
        {
            string rol = string.Empty;

            using (var conexion = _bdConexion.GetConnection())
            {
                string consulta = "SELECT r.nombre AS Rol " +
                              "FROM Usuarios AS u " +
                              "INNER JOIN Rol AS r ON u.id_rol = r.id " +
                              "WHERE u.id = @IdUsuario";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdUsuario", Id);
                conexion.Open();

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        rol = lector["Rol"].ToString();
                    }
                }

                return rol;
            }
        }

        public int AutenticarUsuario(string usuario, string clave)
        {
            using (var conexion = _bdConexion.GetConnection())
            {
                string consulta = "Select * From Usuarios Where nombre = @nombre and clave = @clave";
                conexion.Open();
               
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", usuario);
                comando.Parameters.AddWithValue("@clave", clave);


                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    int usuarioId = (int)lector["id"];

                    return usuarioId;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
