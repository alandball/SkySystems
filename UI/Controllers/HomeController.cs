using System.Web.Mvc;
using Common.Authentications;
using Common.Users;
using UI.ViewModels.ViewModelBuilders;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;
        private readonly HomeViewModelBuilder _viewModelBuilder;

        public HomeController(IAuthenticationService authenticationService, IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;
            _viewModelBuilder = new HomeViewModelBuilder(_authenticationService, _userService);
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
    }
}
