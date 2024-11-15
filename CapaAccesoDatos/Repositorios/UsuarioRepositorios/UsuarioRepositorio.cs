using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
using Dapper;
using Microsoft.Identity.Client;

namespace CapaAccesoDatos.Repositorios.UsuarioRepositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly IAccesoDatosSql _dbConexion;

        public UsuarioRepositorio(IAccesoDatosSql dbConexion)
        {
            _dbConexion = dbConexion;
        }

        public Usuario? ObtenerUsuarioPorCorreoyClave(string Correo, string Clave)
        {
            var consulta = @"SELECT Id, Nombre, Apellido, Clave, Correo, IdRol
                            FROM Usuarios
                            WHERE Correo = @Correo AND Clave = @Clave";

            using (var conexion = _dbConexion.GetConnection())
            {
                return conexion.QueryFirstOrDefault<Usuario>(consulta, new { Correo, Clave });
            }
        }


    }
}
