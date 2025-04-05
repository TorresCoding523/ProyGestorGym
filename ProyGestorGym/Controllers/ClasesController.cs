using COMMON.Entidades;
using COMMON.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyGestorGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasesController : GenericController<Clases>
    {
        public ClasesController() : base(Parametros.FabricaRepository.ClasesRepository())
        {

        }
    }
}
