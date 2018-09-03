using APIPag24horas.Business.cbolso.Implementations;
using APIPag24horas.Data.cbolso.VO;
using Microsoft.AspNetCore.Mvc;
using Tapioca.HATEOAS;

namespace APIPag24horas.Controllers.cbolso
{
    [Route("api/cbolso/v{version:apiVersion}/[controller]/")]
    public class UsuariosController : Controller
    {
        private IUsuariosBusiness _usuariosBusiness;

        public UsuariosController(IUsuariosBusiness usuariosBusiness)
        {
            _usuariosBusiness = usuariosBusiness;
        }

        // GET: api/cbolso/usuarios/v1
        [HttpGet]
        //[Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_usuariosBusiness.FindAll());
        }

        // GET: api/cbolso/usuarios/v1/5
        [HttpGet("{id}")]
        //[Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(int id)
        {
            var usuario = _usuariosBusiness.FindById(id);
            if (usuario == null) return NotFound();

            return Ok(usuario);
        }

        // POST: api/PersonVO/v1
        [HttpPost]
        //[Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]UsuariosVO item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            return new ObjectResult(_usuariosBusiness.Create(item));
        }

        // PUT: api/cbolso/v1/usuarios/
        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]UsuariosVO usuario)
        {
            if (usuario == null) { return BadRequest(); }
            var updatedPerson = _usuariosBusiness.Update(usuario);
            if (updatedPerson == null) return BadRequest();
            return new ObjectResult(updatedPerson);
        }
    }
}

