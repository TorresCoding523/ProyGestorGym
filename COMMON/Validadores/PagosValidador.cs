using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class PagosValidador : CamposControlValidador<Pagos>
    {
        public PagosValidador()
        {
            RuleFor(p => p.UsuarioId).GreaterThan(0);
            RuleFor(p => p.Monto).GreaterThan(0);
            RuleFor(p => p.MetodoPago)
                .NotEmpty()
                .Must(m => new[] { "Tarjeta", "Efectivo", "Transferencia" }.Contains(m))
                .WithMessage("Método de pago inválido");

            RuleFor(p => p.Estado)
                .NotEmpty()
                .Must(e => new[] { "Pagado", "Pendiente", "Fallido" }.Contains(e))
                .WithMessage("Estado debe ser 'Pagado', 'Pendiente' o 'Fallido'");
        }
    }
}
