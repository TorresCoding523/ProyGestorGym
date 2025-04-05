using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class MembresiasValidador : CamposControlValidador<Membresias>
    {
        public MembresiasValidador()
        {
            RuleFor(m => m.Nombre).NotEmpty().MaximumLength(50);
            RuleFor(m => m.Precio).GreaterThan(0);
            RuleFor(m => m.Duracion).GreaterThan(0);
            RuleFor(m => m.Beneficios).NotEmpty();
        }
    }
}
