using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Reservas : CamposControl
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ClaseId { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Estado { get; set; } // Confirmada, Cancelada, Pendiente
    }
}
