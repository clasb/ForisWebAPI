using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace foriswebapi.Controllers
{
    public class NewsController : Controller
    {
        [HttpGet]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        [Route("api/nonsecret")]
        public ActionResult GetNews()
        {
            return Ok("hej");
        }

        [HttpGet]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        [Route("api/secret")]
        public ActionResult GetNews(int id)
        {
            return Ok(User.Claims.Select(c => new { c.Type, c.Value }));
        }
    }
}
