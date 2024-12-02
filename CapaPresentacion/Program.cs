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
using CapaNegocios.Servicios.DevolucionServicios;
using CapaAccesoDatos.Repositorios.DevolucionRepositorios;
using CapaPresentacion.Formularios.EstudianteForms;
using CapaNegocios.Servicios.HistorialServicios;
using CapaAccesoDatos.Repositorios.HistorialRepositorios;
using Microsoft.Extensions.Configuration;
using CapaNegocios.Notificaciones;
using CapaAccesoDatos.Repositorios.PanelRepositorios;
using CapaNegocios.Servicios.PanelServicios;

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
                .ConfigureAppConfiguration((context, config) => {
                    config.AddJsonFile(
                        "appsettings.json",
                        optional: false,
                        reloadOnChange: true
                     );
                })
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
                    services.AddTransient<HistorialForm>();
                    services.AddTransient<PanelForm>();


                    //Repositories
                    services.AddScoped<ILibroRepositorio, LibroRepositorio>();
                    services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
                    services.AddScoped<IPrestamoRepositorio, PrestamoRepositorio>();
                    services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
                    services.AddScoped<IGestionUsuarioRepositorio, GestionUsuarioRepositorio>();
                    services.AddScoped<IDevolucionRepositorio, DevolucionRepositorio>();
                    services.AddScoped<IHistorialRepositorio, HistorialRepositorio>();
                    services.AddScoped<IPanelRepositorio, PanelRepositorio>();


                    //Services
                    services.AddScoped<ILibroServicio, LibroServicio>();
                    services.AddScoped<IUsuarioServicio, UsuarioServicio>();
                    services.AddScoped<IPrestamoServicio, PrestamoServicio>();
                    services.AddScoped<ICategoriaServicios, CategoriaServicios>();
                    services.AddScoped<IGestionUsuarioServicio, GestionUsuarioServicio>();
                    services.AddScoped<IDevolucionServicio, DevolucionServicio>();
                    services.AddScoped<IHistorialServicio, HistorialServicio>();
                    services.AddScoped<IPanelServicio, PanelServicio>();


                    //Notificaciones
                    services.AddScoped<IEmailNotificacion, EmailNotificacion>();

                   

                    //Connection
                    services.AddSingleton<IAccesoDatosSql, AccesoDatosSql>();
                });
        }
    }
}