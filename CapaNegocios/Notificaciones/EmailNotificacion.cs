using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Entidades;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace CapaNegocios.Notificaciones
{
    public class EmailNotificacion : IEmailNotificacion
    {
        private readonly IConfiguration _configuration;

        public EmailNotificacion(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void EnviarEmail(EmailAjustes emailAjustes, string nombreEstudiante, string tituloLibro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress(
                "demo",
                _configuration["EmailSettings:EmailFrom"]));

            mensaje.To.Add(new MailboxAddress(
                emailAjustes.DestinatarioNombre,
                emailAjustes.EmailPara
                ));

            mensaje.Subject = emailAjustes.Encabezado;

            var cuerpo = new BodyBuilder();

            string directorioActual = Directory.GetCurrentDirectory();

            var plantillaRuta = Path.Combine(
                    directorioActual,
                    @"..\..\..\Plantillas",
                    "Emailplantilla.html"
            );

            var templateContent = File.ReadAllText(plantillaRuta);

            templateContent = templateContent
    .Replace("{{Estudiante}}", nombreEstudiante)
    .Replace("{{Libro}}", tituloLibro)
    .Replace("{{FechaPrestamo}}", fechaPrestamo.ToString("dd/MM/yyyy"))
    .Replace("{{FechaDevolucion}}", fechaDevolucion.ToString("dd/MM/yyyy"));

            cuerpo.HtmlBody = templateContent;
            mensaje.Body = cuerpo.ToMessageBody();

            using (var cliente = new SmtpClient())
            {
                cliente.Connect(
                    _configuration["EmailSettings:Host"],
                    Convert.ToInt32(_configuration["EmailSettings:Port"]),
                    false
                );

                cliente.Authenticate(
                    _configuration["EmailSettings:Username"],
                    _configuration["EmailSettings:Password"]);

                cliente.Send(mensaje);
                cliente.Disconnect(true);
            }
        }
    }
}
  
