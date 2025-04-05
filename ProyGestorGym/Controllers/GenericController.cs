using COMMON.Entidades;
using COMMON.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyGestorGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<T> : ControllerBase where T : CamposControl
    {
        protected IDB<T> _repositorio;
        public GenericController(IDB<T> repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<List<T>> Get()
        {
            try
            {
                var datos = _repositorio.ObtenerTodos();
                if (datos != null)
                {
                    return Ok(datos);
                }
                else
                {
                    return BadRequest(_repositorio.Error);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<T> GetById(int id)
        {
            try
            {
                var datos = _repositorio.ObtenerPorId(id);
                if (datos != null)
                {
                    return Ok(datos);
                }
                else
                {
                    return BadRequest(_repositorio.Error);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Insertar un nuevo elemento
        [HttpPost]
        public ActionResult<T> Post([FromBody] T entidad)
        {
            try
            {
                var datos = _repositorio.Insertar(entidad);
                if (datos == null)
                {
                    return BadRequest(_repositorio.Error?.ToString());
                }
                else
                {
                    return Ok(datos);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Eliminar un elemento
        [HttpDelete("{entidad}")]
        public ActionResult<bool> Delete([FromBody] T entidad)
        {
            try
            {
                var datos = _repositorio.Eliminar(entidad);
                if (datos)
                {
                    return Ok(datos);
                }
                else
                {
                    return BadRequest(_repositorio.Error?.ToString());
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Actualizar un elemento
        [HttpPut]
        public ActionResult<T> Put([FromBody] T entidad)
        {
            try
            {
                var datos = _repositorio.Actualizar(entidad);
                if (datos == null)
                {
                    return BadRequest(_repositorio.Error?.ToString());
                }
                else
                {
                    return Ok(datos);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
