using APIPag24horas.Business.cbolso.Implementations;
using APIPag24horas.Data.cbolso.VO;
using Microsoft.AspNetCore.Mvc;
using Tapioca.HATEOAS;

namespace APIPag24horas.Controllers.cbolso
{
    [Route("api/cbolso/v{version:apiVersion}/[controller]/")]
    public class FuncionariosController : Controller
    {
        private IFuncionariosBusiness _funcionariosBusiness;

        public FuncionariosController(IFuncionariosBusiness usuariosBusiness)
        {
            _funcionariosBusiness = usuariosBusiness;
        }

        // GET: api/cbolso/usuarios/v1
        [HttpGet]
        //[Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_funcionariosBusiness.FindAll());
        }

        // GET: api/cbolso/usuarios/v1/5
        [HttpGet("{id}")]
        //[Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(int id)
        {
            var usuario = _funcionariosBusiness.FindById(id);
            if (usuario == null) return NotFound();

            return Ok(usuario);
        }

        // POST: api/PersonVO/v1
        [HttpPost]
        //[Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]FuncionariosVO item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            return new ObjectResult(_funcionariosBusiness.Create(item));
        }

        // PUT: api/cbolso/v1/usuarios/
        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]FuncionariosVO funcionario)
        {
            if (funcionario == null) { return BadRequest(); }
            var updateFuncionario = _funcionariosBusiness.Update(funcionario);
            if (updateFuncionario == null) return BadRequest();
            return new ObjectResult(updateFuncionario);
        }

        // PATCH: api/cbolso/v1/funcionarios/
        [HttpPatch]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Patch([FromBody]FuncionariosVO funcionario)
        {
            if (funcionario == null) { return BadRequest(); }
            var updatedFuncionario = _funcionariosBusiness.Update(funcionario);
            if (updatedFuncionario == null) return BadRequest();
            return new ObjectResult(updatedFuncionario);
        }
    }
}

