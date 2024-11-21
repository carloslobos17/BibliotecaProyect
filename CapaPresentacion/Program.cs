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

            Application.Run(ServiceProvider.GetRequiredService<LoginFormulario>());
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

                    //Repositories
                    services.AddScoped<ILibroRepositorio, LibroRepositorio>();
                    services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
                    services.AddScoped<IPrestamoRepositorio, PrestamoRepositorio>();
                    services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
                    services.AddScoped<IGestionUsuarioRepositorio, GestionUsuarioRepositorio>();

                    //Services
                    services.AddScoped<ILibroServicio, LibroServicio>();
                    services.AddScoped<IUsuarioServicio, UsuarioServicio>();
                    services.AddScoped<IPrestamoServicio, PrestamoServicio>();
                    services.AddScoped<ICategoriaServicios, CategoriaServicios>();
                    services.AddScoped<IGestionUsuarioServicio, GestionUsuarioServicio>();

                    //Connection
                    services.AddSingleton<IAccesoDatosSql, AccesoDatosSql>();
                });
        }
    }
}