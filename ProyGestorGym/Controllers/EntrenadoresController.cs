using COMMON.Entidades;
using COMMON.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyGestorGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrenadoresController : GenericController<Entrenadores>
    {
        public EntrenadoresController() : base(Parametros.FabricaRepository.EntrenadoresRepository())
        {

        }
    }
}
