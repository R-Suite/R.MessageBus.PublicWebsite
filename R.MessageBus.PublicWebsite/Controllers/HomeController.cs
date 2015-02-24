using System.Web.Mvc;

namespace R.MessageBus.PublicWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guides()
        {
            return View();
        }
    }
}
