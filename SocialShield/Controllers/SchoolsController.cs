using System.Web.Mvc;

namespace SocialShield.Controllers
{
    [Authorize]
    public class SchoolsController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}