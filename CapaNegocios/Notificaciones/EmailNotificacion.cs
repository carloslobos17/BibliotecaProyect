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
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(
                "demo",
                _configuration["EmailSettings:EmailFrom"]));

            message.To.Add(new MailboxAddress(
                emailAjustes.DestinatarioNombre,
                emailAjustes.EmailPara
                ));

            message.Subject = emailAjustes.Encabezado;

            var body = new BodyBuilder();

            string currentDirectory = Directory.GetCurrentDirectory();

            var templatePath = Path.Combine(
                    currentDirectory,
                    @"..\..\..\Plantillas",
                    "Emailplantilla.html"
            );

            var templateContent = File.ReadAllText(templatePath);

            templateContent = templateContent
    .Replace("{{Estudiante}}", nombreEstudiante)
    .Replace("{{Libro}}", tituloLibro)
    .Replace("{{FechaPrestamo}}", fechaPrestamo.ToString("dd/MM/yyyy"))
    .Replace("{{FechaDevolucion}}", fechaDevolucion.ToString("dd/MM/yyyy"));

            body.HtmlBody = templateContent;
            message.Body = body.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect(
                    _configuration["EmailSettings:Host"],
                    Convert.ToInt32(_configuration["EmailSettings:Port"]),
                    false
                );

                client.Authenticate(
                    _configuration["EmailSettings:Username"],
                    _configuration["EmailSettings:Password"]);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
  
