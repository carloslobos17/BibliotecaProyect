﻿using CapaAccesoDatos.Repositorios.GestionUsuarioRepositorios;
using CapaEntidad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Servicios.GestionUsuarioServicios
{
    public class GestionUsuarioServicio : IGestionUsuarioServicio
    {
        private readonly IGestionUsuarioRepositorio _gestionUsuarioRepositorio;

        public GestionUsuarioServicio(IGestionUsuarioRepositorio gestionUsuarioRepositorio)
        {
            _gestionUsuarioRepositorio = gestionUsuarioRepositorio;
        }

        public IEnumerable<Usuario> ObtenerBibliotecarios() => _gestionUsuarioRepositorio.ObtenerBibliotecarios();
        public IEnumerable<Usuario> ObtenerAdministrador() => _gestionUsuarioRepositorio.ObtenerAdministrador();
        public IEnumerable<Usuario> ObtenerEstudiantes() => _gestionUsuarioRepositorio.ObtenerEstudiantes();

        public void AgregarUsuario(Usuario usuario) => _gestionUsuarioRepositorio.AgregarUsuario(usuario);

        public void EditarUsuario(Usuario usuario) => _gestionUsuarioRepositorio.EditarUsuario(usuario);

        public void EliminarUsuario(int id) => _gestionUsuarioRepositorio.EliminarUsuario(id);

        public IEnumerable<Usuario> ObtenerUsuariosFiltrados() => _gestionUsuarioRepositorio.ObtenerUsuariosFiltrados();

        public IEnumerable<Usuario> ObtenerAdminFiltrados() => _gestionUsuarioRepositorio.ObtenerAdminFiltrados();

        public IEnumerable<Usuario> ObtenerBibliotecariosFiltrados() => _gestionUsuarioRepositorio.ObtenerBibliotecariosFiltrados();
    }
}
