using System.Web.Mvc;
using Common.Authentications;
using Common.Models;
using Common.Users;
using Omu.ValueInjecter;
using UI.Filters;
using UI.ViewModels;
using UI.ViewModels.ViewModelBuilders;
using WebMatrix.WebData;

namespace UI.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;
        private readonly AuthenticationViewModelBuilder _viewModelBuilder;

        public AuthenticationController(IAuthenticationService authenticationService, IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;
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
            try
            {
                if (ModelState.IsValid)
                {
                    var authentication = new Authentication();
                    authentication.InjectFrom(model);


                    var success = _authenticationService.CreateUpdate(authentication);

                    if (success > 0)
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    return View("CreateUpdate", model);
                }

                return View("CreateUpdate", model);
            }
            catch
            {
                return View("CreateUpdate");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
                if (WebSecurity.GetUserId(username) == -1)
                {
                    // If we got this far, something failed, redisplay form
                    ModelState.AddModelError("", "Sorry, your account does not exist. Please report this to your manager.");
                    return RedirectToAction("Index", "Home");
                    
                }

                var test = WebSecurity.Login(username, password, persistCookie: true);
                return RedirectToAction("Index", "Home");
            }

            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return RedirectToAction("Index", "Home");
        }


    }
}