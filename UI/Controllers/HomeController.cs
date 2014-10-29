using System.Web.Mvc;
using Common.Authentications;
using Common.Users;
using UI.ViewModels.ViewModelBuilders;

namespace UI.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUserService _userService;
        private readonly HomeViewModelBuilder _viewModelBuilder;

        public HomeController(IUserService userService)
        {

            _userService = userService;
            _viewModelBuilder = new HomeViewModelBuilder( _userService);
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Test()
        {
            return PartialView("Test");
        }
    }
}
