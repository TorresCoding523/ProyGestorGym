using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class ClasesValidador : CamposControlValidador<Clases>
    {
        public ClasesValidador()
        {
            RuleFor(c => c.Nombre).NotEmpty().MaximumLength(50);
            RuleFor(c => c.Descripcion).NotEmpty();
            RuleFor(c => c.CupoMaximo).GreaterThan(0);
            RuleFor(c => c.Fecha).GreaterThanOrEqualTo(DateTime.Today);
            RuleFor(c => c.Hora).NotEmpty();
            RuleFor(c => c.EntrenadorId).GreaterThan(0);
        }
    }
}
