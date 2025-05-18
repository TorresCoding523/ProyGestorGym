using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Membresias : CamposControl
    {
        public int IdMembresia { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Duracion { get; set; } // En días
        public string Beneficios { get; set; }
    }
}
