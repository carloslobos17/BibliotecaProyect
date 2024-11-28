using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using CapaEntidad.Entidades;

namespace CapaPresentacion.Validaciones
{
    public class ValidacionPrestamo: AbstractValidator<Prestamo>
    {
        public ValidacionPrestamo()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(prestamo => prestamo.IdUsuario)
                 .NotEmpty().WithMessage("El campo del estudiante no puede estar vacía.")
                 .GreaterThanOrEqualTo(1).WithMessage("Debe seleccionar un estudiante válido.");

            RuleFor(prestamo => prestamo.IdLibro)
                 .NotEmpty().WithMessage("El campo del libro no puede estar vacío.")
                 .GreaterThanOrEqualTo(1).WithMessage("Debe seleccionar un libro válida.");

            RuleFor(prestamo => prestamo.FechaDevolucion)
                .NotEmpty().WithMessage("La fecha de devolucion no puede estar vacía.")
                .Must(fecha => fecha.Date >= DateTime.Now.Date).WithMessage("La fecha de devolución no puede ser en el pasado.");


            RuleFor(prestamo => prestamo.FechaPrestamo)
                .NotEmpty().WithMessage("La fecha de prestamo no puede estar vacía.")
                .Must(fecha => fecha >= DateTime.Now.Date).WithMessage("La fecha de prestamo no puede ser en el pasado.");

        }
    }
}
