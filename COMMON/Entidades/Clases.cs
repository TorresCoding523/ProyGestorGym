using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Clases : CamposControl
    {
        public int IdClase { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CupoMaximo { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int EntrenadorId { get; set; }
    }
}