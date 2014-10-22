using System.Web.Mvc;
using Common.Authentications;
using Common.Models;
using Omu.ValueInjecter;
using UI.ViewModels;
using UI.ViewModels.ViewModelBuilders;

namespace UI.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly AuthenticationViewModelBuilder _viewModelBuilder;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
            _viewModelBuilder = new AuthenticationViewModelBuilder();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create(int userId)
        {
            var model = _viewModelBuilder.BuildCreateViewModel(userId);
            return View("CreateUpdate", model);
        }

        [HttpPost]
        public ActionResult Create(AuthenticationCreateUpdateViewModel model)
        {
            var authentication = new Authentication();
            authentication.InjectFrom(model);

            _authenticationService.CreateUpdate(authentication);

            return RedirectToAction("Index", "Home");
        }
	}
}