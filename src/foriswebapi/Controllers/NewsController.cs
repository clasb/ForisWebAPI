using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;
using System.Security.Claims;

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
            var identity = User.Identity as ClaimsIdentity;

            var claims = from c in identity.Claims
                         select new
                         {
                             subject = c.Subject.Name,
                             type = c.Type,
                             value = c.Value
                         };

            return Ok(claims);
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
