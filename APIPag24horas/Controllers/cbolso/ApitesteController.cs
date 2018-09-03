using APIPag24horas.Business.cbolso.Implementations;
using APIPag24horas.Data.cbolso.VO;
using Microsoft.AspNetCore.Mvc;
using Tapioca.HATEOAS;

namespace APIPag24horas.Controllers.cbolso
{
	[Route("api/cbolso/v{version:apiVersion}/[controller]/")]
    public class ApitesteController : Controller
    {
        private IApitesteBusiness _apitesteBusiness;

        public ApitesteController(IApitesteBusiness apitesteBusiness)
        {
            _apitesteBusiness = apitesteBusiness;
        }

        // GET: api/Person/v1
        [HttpGet]
        //[Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_apitesteBusiness.FindAll());
        }

        // POST: api/PersonVO/v1
        [HttpPost]
        //[Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]ApitesteVO item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            return new ObjectResult(_apitesteBusiness.Create(item));
        }
    }
}

