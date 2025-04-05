using COMMON.Entidades;
using COMMON.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyGestorGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembresiasController : GenericController<Membresias>
    {
        public MembresiasController() : base(Parametros.FabricaRepository.MembresiasRepository())
        {

        }
    }
}
