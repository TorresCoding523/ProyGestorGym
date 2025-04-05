using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class ReservasValidador : CamposControlValidador<Reservas>
    {
        public ReservasValidador()
        {
            RuleFor(r => r.UsuarioId).GreaterThan(0);
            RuleFor(r => r.ClaseId).GreaterThan(0);
            RuleFor(r => r.Estado)
                .NotEmpty()
                .Must(estado => new[] { "Confirmada", "Cancelada", "Pendiente" }.Contains(estado))
                .WithMessage("Estado debe ser 'Confirmada', 'Cancelada' o 'Pendiente'");
        }
    }
}
