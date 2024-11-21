﻿using CapaAccesoDatos.ConexionBD;
using CapaEntidad.Entidades;
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

        public IEnumerable<Usuario> ObtenerUsuario()
        {
            using (var conexion = _dbConexion.GetConnection())
            {
                string consulta = @"SELECT * FROM Usuarios";

                return conexion.Query<Usuario>(consulta);
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