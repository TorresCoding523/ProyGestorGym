using COMMON.Entidades;
using COMMON.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyGestorGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : GenericController<Usuarios>
    {
        public UsuariosController() : base(Parametros.FabricaRepository.UsuariosRepository())
        {
        }
    }
}
