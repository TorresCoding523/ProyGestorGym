using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.Manager
{
    public class UsuariosManager : GenericManager<Usuarios>
    {
        public UsuariosManager(AbstractValidator<Usuarios> validator) : base(validator)
        {
        }
    }
}
