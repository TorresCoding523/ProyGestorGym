using COMMON.Entidades;
using COMMON.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyGestorGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosController : GenericController<Pagos>
    {
        public PagosController() : base(Parametros.FabricaRepository.PagosRepository())
        {
        }
    }
}
