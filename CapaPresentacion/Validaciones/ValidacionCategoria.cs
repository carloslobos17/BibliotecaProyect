using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Entidades;
using FluentValidation;

namespace CapaPresentacion.Validaciones
{
    public class ValidacionCategoria: AbstractValidator<Categoria>
    {
        public ValidacionCategoria()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(categoria => categoria.Nombre)
                .NotEmpty().WithMessage("El Nombre de la categoria no puede estar vacío.")
                .MaximumLength(254).WithMessage("El correo no puede exceder los 254 caracteres.");
        }
    }
}
