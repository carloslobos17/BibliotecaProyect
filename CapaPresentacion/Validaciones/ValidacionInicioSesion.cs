using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Entidades;
using FluentValidation;

namespace CapaPresentacion.Validaciones
{
    public class ValidacionInicioSesion: AbstractValidator<Usuario>
    {
        public ValidacionInicioSesion()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(usuario => usuario.Correo)
                .NotEmpty().WithMessage("El correo no puede estar vacío.")
                .EmailAddress().WithMessage("El formato del correo electrónico es inválido.")
                .MaximumLength(254).WithMessage("El correo no puede exceder los 254 caracteres.");

            RuleFor(usuario => usuario.Clave)
                .NotEmpty().WithMessage("La clave no puede estar vacía.");
        }
    }
}
