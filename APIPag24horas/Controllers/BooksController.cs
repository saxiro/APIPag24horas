using APIPag24horas.Business;
using APIPag24horas.Data.VO;
using Microsoft.AspNetCore.Mvc;
using Tapioca.HATEOAS;

namespace APIPag24horas.Controllers
{
    [Produces("application/json")]
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]


    public class BooksController : Controller
    {

        private IBookBusiness _bookBusiness;

        public BooksController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;
        }

        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var book = _bookBusiness.FindById(id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        // POST: api/books/v1
        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]BookVO book)
        {
            if (book == null)
            {
                return BadRequest();
            }

            return new ObjectResult(_bookBusiness.Create(book));
        }

        // PUT: api/Person/v1/5
        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]BookVO book)
        {
            if (book == null) { return BadRequest(); }
            var updatedBook = _bookBusiness.Update(book);
            if (updatedBook == null) return BadRequest();
            return new ObjectResult(updatedBook);
        }

        // DELETE: api/Person/v1/5
        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Delete(long id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}
