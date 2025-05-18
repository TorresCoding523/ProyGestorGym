using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.Manager
{
    public class ReservasManager : GenericManager<Reservas>
    {
        public ReservasManager(AbstractValidator<Reservas> validator) : base(validator)
        {
        }
    }
}
