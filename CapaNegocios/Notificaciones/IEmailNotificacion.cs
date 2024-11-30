using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Entidades;

namespace CapaNegocios.Notificaciones
{
    public interface IEmailNotificacion
    {
        void EnviarEmail(EmailAjustes emailAjustes, string nombreEstudiante, string tituloLibro, DateTime fechaPrestamo, DateTime fechaDevolucion);
    }
}
