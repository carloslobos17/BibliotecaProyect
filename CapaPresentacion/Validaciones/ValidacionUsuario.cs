using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Entidades;
using FluentValidation;
namespace CapaPresentacion.Validaciones
{
    public class ValidacionUsuario : AbstractValidator<Usuario>
    {
        public ValidacionUsuario()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(usuario => usuario.Nombre)
                .NotEmpty().WithMessage("El nombre no puede estar vacío.")
                .MinimumLength(3).WithMessage("El nombre debe contener al menos 3 letras.")
                .MaximumLength(100).WithMessage("El nombre no puede exceder los 100 caracteres.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre solo puede contener letras y espacios.");

            RuleFor(usuario => usuario.Apellido)
                .NotEmpty().WithMessage("El apellido no puede estar vacío.")
                .Length(3, 100).WithMessage("El apellido debe contener entre 3 y 100 letras.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("El apellido solo puede contener letras y espacios.");

            RuleFor(usuario => usuario.Edad)
                .NotEmpty().WithMessage("La edad no puede estar vacía.")
                .GreaterThan(0).WithMessage("La edad debe ser un valor positivo.")
                .LessThanOrEqualTo(120).WithMessage("La edad no puede ser mayor de 120 años.");

            RuleFor(usuario => usuario.Clave)
                .NotEmpty().WithMessage("La clave no puede estar vacía.")
                .MinimumLength(8).WithMessage("La clave debe tener al menos 8 caracteres.")
                .Matches(@"[A-Z]").WithMessage("La clave debe contener al menos una letra mayúscula.")
                .Matches(@"[a-z]").WithMessage("La clave debe contener al menos una letra minúscula.")
                .Matches(@"\d").WithMessage("La clave debe contener al menos un número.")
                .Matches(@"[\W]").WithMessage("La clave debe contener al menos un carácter especial.");

            RuleFor(usuario => usuario.Telefono)
                .NotEmpty().WithMessage("El teléfono no puede estar vacío.")
                .Matches(@"^\d{8,15}$").WithMessage("El teléfono debe contener entre 8 y 15 dígitos y solo números.");

            RuleFor(usuario => usuario.Correo)
                .NotEmpty().WithMessage("El correo no puede estar vacío.")
                .EmailAddress().WithMessage("El formato del correo electrónico es inválido.")
                .MaximumLength(254).WithMessage("El correo no puede exceder los 254 caracteres.");
        }
    }
}
