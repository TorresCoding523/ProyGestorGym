using COMMON.Entidades;
using COMMON.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyGestorGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : GenericController<Reservas>
    {
        public ReservasController() : base(Parametros.FabricaRepository.ReservasRepository())
        {
        }
    }
}
