using APIPag24horas.Business;
using Microsoft.AspNetCore.Mvc;
using APIPag24horas.Data.VO;
using Tapioca.HATEOAS; 
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using APIPag24horas.Model;

namespace APIPag24horas.Controllers
{
    //[Produces("application/json")]
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class LoginController : Controller
    {
        private ILoginBusiness _loginBusiness;

        public LoginController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }
        
        [AllowAnonymous]
        [HttpPost]
        public object Post([FromBody]UserVO user)
        {
            if (user == null) return BadRequest();
            return _loginBusiness.FindByLogin(user);
        }
        
    }
}
