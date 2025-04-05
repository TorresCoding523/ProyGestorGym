using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class UsuariosValidador : CamposControlValidador<Usuarios>
    {
        public UsuariosValidador()
        {
            RuleFor(u => u.Nombre).NotEmpty().MaximumLength(50);
            RuleFor(u => u.Apellido).NotEmpty().MaximumLength(50);
            RuleFor(u => u.Email).NotEmpty().EmailAddress().MaximumLength(100);
            RuleFor(u => u.Contraseña)
                .NotEmpty()
                .MinimumLength(8)  // Mínimo 8 caracteres para mayor seguridad
                .MaximumLength(255)
                .Matches("[A-Z]").WithMessage("La contraseña debe contener al menos una mayúscula")
                .Matches("[a-z]").WithMessage("La contraseña debe contener al menos una minúscula")
                .Matches("[0-9]").WithMessage("La contraseña debe contener al menos un número");
            RuleFor(u => u.Telefono).MaximumLength(20);
        }
    }
}