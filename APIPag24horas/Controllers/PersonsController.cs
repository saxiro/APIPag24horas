using APIPag24horas.Business;
using Microsoft.AspNetCore.Mvc;
using APIPag24horas.Data.VO;
using Tapioca.HATEOAS; 
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace APIPag24horas.Controllers
{
    //[Produces("application/json")]
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonsController : Controller
    {
        private IPersonBusiness _personBusiness;

        public PersonsController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        // GET: api/Person/v1
        [HttpGet]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        // GET: api/Person/v1/?
        [HttpGet("find-by-name")]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetByName([FromQuery] string firstName,[FromQuery] string lastName)
        {
            return Ok(_personBusiness.FindByName(firstName,lastName));
        }

        // GET: api/Person/v1/5
        [HttpGet("{id}")]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var person = _personBusiness.FindById(id);
            if(person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }
        
        // POST: api/PersonVO/v1
        [HttpPost]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]PersonVO person)
        {
            if (person == null)
            {
                return BadRequest();
            }

            return new ObjectResult(_personBusiness.Create(person));
        }
        
        // PUT: api/Person/v1/5
        [HttpPut]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]PersonVO person)
        {
            if (person == null){return BadRequest();}
            var updatedPerson = _personBusiness.Update(person);
            if (updatedPerson == null) return BadRequest();
            return new ObjectResult(updatedPerson);
        }

        // PUT: api/Person/v1/5
        [HttpPatch]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Patch([FromBody]PersonVO person)
        {
            if (person == null) { return BadRequest(); }
            var updatedPerson = _personBusiness.Update(person);
            if (updatedPerson == null) return BadRequest();
            return new ObjectResult(updatedPerson);
        }

        // DELETE: api/Person/v1/5
        [HttpDelete("{id}")]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
