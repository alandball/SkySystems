using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View("Index");
        }

        public ActionResult About()
        {
            return View("About");
        }

        public ActionResult Contact()
        {
            return View("Contact");
        }
    }
}
