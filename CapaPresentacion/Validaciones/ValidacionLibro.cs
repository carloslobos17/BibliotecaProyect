using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Entidades;
using FluentValidation;

namespace CapaPresentacion.Validaciones
{
    public class ValidacionLibro : AbstractValidator<Libro>
    {
        public ValidacionLibro()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(libro => libro.Titulo)
                .NotEmpty().WithMessage("El título no puede estar vacío.")
                .MinimumLength(3).WithMessage("El título debe contener al menos 3 caracteres.")
                .MaximumLength(100).WithMessage("El título no puede exceder los 100 caracteres.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("El título solo puede contener letras y espacios.");

            RuleFor(libro => libro.Autor)
                .NotEmpty().WithMessage("El autor no puede estar vacío.")
                .MinimumLength(3).WithMessage("El autor debe contener al menos 3 caracteres.")
                .MaximumLength(50).WithMessage("El autor no puede exceder los 50 caracteres.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("El autor solo puede contener letras y espacios.");

            RuleFor(libro => libro.FechaPublicacion)
                .NotEmpty().WithMessage("La fecha de publicación no puede estar vacía.")
                .Must(fecha => fecha <= DateTime.Now).WithMessage("La fecha de publicación no puede ser en el futuro.");

            RuleFor(libro => libro.CopiasDisponibles)
                .NotEmpty().WithMessage("El número de copias disponibles no puede estar vacío.")
                .GreaterThanOrEqualTo(1).WithMessage("El número de copias disponibles no puede ser negativo.");

            RuleFor(libro => libro.IdCategoria)
                .NotEmpty().WithMessage("La categoría del libro no puede estar vacía.")
                .GreaterThanOrEqualTo(1).WithMessage("Debe seleccionarse una categoría válida.");
        }
    }
}
