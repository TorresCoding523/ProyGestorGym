using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class CamposControlValidador<T> : AbstractValidator<T> where T : CamposControl
    {
        public CamposControlValidador()
        {
            RuleFor(c => c.FechaAlta).NotEmpty().GreaterThanOrEqualTo(new DateTime(2025, 1, 1));
            RuleFor(c => c.UsuarioAlta).NotEmpty().MinimumLength(5).MaximumLength(50);
            RuleFor(c => c.UsuarioMod).MaximumLength(50);
        }
    }
}
