using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using foriswebapi.Models;
using foriswebapi.Models.Interfaces;
using Microsoft.AspNet.Authorization;

namespace foriswebapi.Controllers
{
    [Route("api/")]
    public class TrailController : Controller
    {
        private readonly ITrailsRepository Trails;
        public TrailController(ITrailsRepository trails)
        {
            Trails = trails;
        }

        [HttpGet]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        [Route("alltrails")]
        public IActionResult GetAllTrails()
        {
            try
            {
                var trails = Trails.GetAllTrails();
                if (trails == null || trails.Count() == 0)
                {
                    return HttpNotFound();
                }
                return this.Ok(trails);
            }
            catch (Exception e)
            {
                return HttpBadRequest();
            }
        }

        [HttpGet]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        [Route("trails")]
        public IActionResult GetTrailsInProximity(long latitude, long longitude, int radius)
        {
            try
            {
                var trail = Trails.GetTrails(latitude, longitude, radius);
                if (trail == null)
                {
                    return HttpNotFound();
                }
                return this.Ok(trail);
            }
            catch
            {
                return HttpBadRequest();
            }
        }

        [HttpGet]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        [Route("trail")]
        public IActionResult GetTrailOnId(string id)
        {
            try
            {
                var trail = Trails.GetTrail(id);
                if (trail == null)
                {
                    return HttpNotFound();
                }
                return Ok(trail);
            }
            catch
            {
                return HttpBadRequest();
            }
        }

        [HttpPost]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        [Route("trail")]
        public IActionResult AddTrail([FromBody]Trail trail)
        {
            try
            {
                var newTrail = Trails.AddTrail(trail);
                if (trail == null)
                {
                    return HttpNotFound();
                }
                return Created("/trail/" + newTrail.Id, newTrail);
            }
            catch
            {
                return HttpBadRequest();
            }
        }

        [HttpPut]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        [Route("trail")]
        public IActionResult UpdateTrail(string id, [FromBody]Trail trail)
        {
            try
            {
                var updatedTrail = Trails.UpdateTrail(id, trail);
                if (trail == null)
                {
                    return HttpNotFound();
                }
                return Ok(updatedTrail);
            }
            catch
            {
                return HttpBadRequest();
            }
        }

        [HttpDelete]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        [Route("trail")]
        public IActionResult DeleteTrail(string id)
        {
            try
            {
                var deleted = Trails.DeleteTrail(id);
                if (!deleted)
                {
                    return HttpNotFound();
                }
                return Ok();
            }
            catch
            {
                return HttpBadRequest();

            }
        }
    }
}
