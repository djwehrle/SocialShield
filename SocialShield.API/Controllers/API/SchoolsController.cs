using System;
using System.Web.Http;

namespace SocialShield.API.Controllers.API
{
    [RoutePrefix("api/Schools")]
    [Authorize]
    public class SchoolsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}