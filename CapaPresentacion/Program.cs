using System;
using CapaPresentacion.Formulario;
using CapaAccesoDatos.ConexionBD;
using CapaAccesoDatos.Repositorios;
using CapaPresentacion.Formularios.BibliotecarioForms;
using CapaAccesoDatos.Repositorios.LibroRepositorios;
using CapaNegocios.Servicios.LibroServicios;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using CapaAccesoDatos.Repositorios.UsuarioRepositorios;
using CapaNegocios.Servicios.UsuarioServicios;
using CapaAccesoDatos.Repositorios.PrestamoRepositorios;
using CapaNegocios.Servicios.PrestamoServicios;
using CapaPresentacion.Formularios.BibliotecarioForms.Modal;
using CapaAccesoDatos.Repositorios.CategoriasRepositorios;
using CapaNegocios.Servicios.CategoriaServicios;
using CapaAccesoDatos.Repositorios.GestionUsuarioRepositorios;
using CapaNegocios.Servicios.GestionUsuarioServicios;
using CapaPresentacion.Formularios.AdminForms;
using CapaAccesoDatos.Repositorios.EstudianteRepositorios;
using CapaNegocios.Servicios.EstudianteServicios;
using CapaNegocios.Servicios.AdministradorServicios;
using CapaAccesoDatos.Repositorios.AdministradorRepositorios;
using CapaNegocios.Servicios.DevolucionServicios;
using CapaAccesoDatos.Repositorios.DevolucionRepositorios;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<PrincipalForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    //Forms
                    services.AddTransient<GestionarLibrosForm>();
                    services.AddTransient<LoginFormulario>();
                    services.AddTransient<PrincipalForm>();
                    services.AddTransient<PrestamosForm>();
                    services.AddTransient<CategoriaForm>();
                    services.AddTransient<BibliotecariosForm>();
                    services.AddTransient<EstudiantesForm>();
                    services.AddTransient<AdministradorForm>();
                    services.AddTransient<DevolucionesForm>();

                    //Repositories
                    services.AddScoped<ILibroRepositorio, LibroRepositorio>();
                    services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
                    services.AddScoped<IPrestamoRepositorio, PrestamoRepositorio>();
                    services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
                    services.AddScoped<IGestionUsuarioRepositorio, GestionUsuarioRepositorio>();
                    services.AddScoped<IEstudianteRepositorio, EstudianteRepositorio>();
                    services.AddScoped<IAdministradorRepositorio, AdministradorRepositorio>();
                    services.AddScoped<IDevolucionRepositorio, DevolucionRepositorio>();

                    //Services
                    services.AddScoped<ILibroServicio, LibroServicio>();
                    services.AddScoped<IUsuarioServicio, UsuarioServicio>();
                    services.AddScoped<IPrestamoServicio, PrestamoServicio>();
                    services.AddScoped<ICategoriaServicios, CategoriaServicios>();
                    services.AddScoped<IGestionUsuarioServicio, GestionUsuarioServicio>();
                    services.AddScoped<IEstudianteServicio, EstudianteServicio>();
                    services.AddScoped<IAdministradorServicio, AdministradorServicio>();
                    services.AddScoped<IDevolucionServicio, DevolucionServicio>();

                    //Connection
                    services.AddSingleton<IAccesoDatosSql, AccesoDatosSql>();
                });
        }
    }
}