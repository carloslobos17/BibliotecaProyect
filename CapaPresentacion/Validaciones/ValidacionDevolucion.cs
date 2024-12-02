using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Entidades;
using FluentValidation;

namespace CapaPresentacion.Validaciones
{
    public class ValidacionDevolucion: AbstractValidator<Devolucion>
    {
        public ValidacionDevolucion()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;


            RuleFor(devolucion => devolucion.Observaciones)
               .MaximumLength(100).WithMessage("las observaciones no puede exceder los 100 caracteres");

            RuleFor(devolucion => devolucion.FechaDevolucion)
                .NotEmpty().WithMessage("La fecha de devolucion no puede estar vacía.")
                .Must(fecha => fecha.Date >= DateTime.Now.Date).WithMessage("La fecha de devolución no puede ser en el pasado.");


        }
    }
}
