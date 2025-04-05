using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class EntrenadoresValidador : CamposControlValidador<Entrenadores>
    {
        public EntrenadoresValidador()
        {
            RuleFor(e => e.Nombre).NotEmpty().MaximumLength(50);
            RuleFor(e => e.Especialidad).MaximumLength(100);
            RuleFor(e => e.Telefono).MaximumLength(20);
            RuleFor(e => e.Email).EmailAddress().MaximumLength(100);
        }
    }
}
