using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.Manager
{
    public abstract class FabricManager
    {
        public static EntrenadoresManager EntrenadoresManager => new EntrenadoresManager(new EntrenadoresValidador());

        public static ClasesManager ClasesManager => new ClasesManager(new ClasesValidador());
    }
}
