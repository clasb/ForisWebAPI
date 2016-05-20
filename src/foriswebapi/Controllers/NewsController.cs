using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace foriswebapi.Controllers
{
    [Route("api/")]
    public class NewsController : Controller
    {
        [HttpGet]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        [Route("news")]
        public ActionResult GetNews()
        {
            return Ok("hej");
        }

        [HttpGet]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        [Route("news9")]
        public ActionResult GetNews(int id)
        {
            return Ok(User.Claims.Select(c => new { c.Type, c.Value }));
        }
    }
}
