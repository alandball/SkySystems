//using System;
//using System.Transactions;
//using System.Web.Mvc;
//using System.Web.Security;
//using Common.Users;
//using Microsoft.Web.WebPages.OAuth;
//using UI.ViewModels;
//using WebMatrix.WebData;

//namespace UI.Controllers
//{
//    public class AccountController : Controller
//    {
//        private readonly IUserService _userService;

//        public AccountController(IUserService userService)
//        {
//            _userService = userService;
//        }

//        [AllowAnonymous]
//        public ActionResult Login(string returnUrl)
//        {
//            ViewBag.ReturnUrl = returnUrl;
//            return View();
//        }

//        [HttpPost]
//        [AllowAnonymous]
//        //[ValidateAntiForgeryToken]
//        [ValidateAntiForgeryToken]
//        public ActionResult Login(LoginModel model, string returnUrl)
//        {
//            if (ModelState.IsValid)
//            {
//                if (WebSecurity.GetUserId(model.UserName) == -1)
//                {
//                    // If we got this far, something failed, redisplay form
//                    ModelState.AddModelError("", "Sorry, your account does not exist. Please report this to your manager.");
//                    return View(model);
//                }

//                var user = _userService.Get(WebSecurity.GetUserId(model.UserName));

//                if (WebSecurity.Login(model.UserName, model.Password, persistCookie: model.RememberMe))
//                {
//                    return RedirectToLocal(returnUrl);
//                }

//                var loginSuccessful = WebSecurity.Login(model.UserName, model.Password, persistCookie: model.RememberMe);

//                if (loginSuccessful)
//                {
//                    return RedirectToLocal(returnUrl);
//                }
//            }

//            // If we got this far, something failed, redisplay form
//            ModelState.AddModelError("", "The user name or password provided is incorrect.");
//            return View(model);
//        }

//        [HttpPost]
//        //[ValidateAntiForgeryToken]
//        public ActionResult LogOff()
//        {
//            WebSecurity.Logout();

//            return RedirectToAction("Index", "Home");
//        }

//        [AllowAnonymous]
//        public ActionResult Register()
//        {
//            return View();
//        }

//        [HttpPost]
//        [AllowAnonymous]
//        public ActionResult Register(RegisterModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                // Attempt to register the user
//                try
//                {
//                    WebSecurity.CreateUserAndAccount(model.UserName, model.Password,
//                        new
//                        {
//                            BranchId = 1,
//                            UserTypeId = 1,
//                            IsDeleted = false,
//                            DateCreated = DateTime.Now,
//                            UserIdCreatedBy = 2
//                        }, true);
//                    var test = WebSecurity.Login(model.UserName, model.Password);
//                    return RedirectToAction("Index", "Home");
//                }
//                catch (MembershipCreateUserException e)
//                {
//                    ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
//                }
//            }

//            // If we got this far, something failed, redisplay form
//            return View(model);
//        }

//        [HttpPost]
//        //[ValidateAntiForgeryToken]
//        public ActionResult Disassociate(string provider, string providerUserId)
//        {
//            string ownerAccount = OAuthWebSecurity.GetUserName(provider, providerUserId);
//            ManageMessageId? message = null;

//            // Only disassociate the account if the currently logged in user is the owner
//            if (ownerAccount == User.Identity.Name)
//            {
//                // Use a transaction to prevent the user from deleting their last login credential
//                using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.Serializable }))
//                {
//                    bool hasLocalAccount = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
//                    if (hasLocalAccount || OAuthWebSecurity.GetAccountsFromUserName(User.Identity.Name).Count > 1)
//                    {
//                        OAuthWebSecurity.DeleteAccount(provider, providerUserId);
//                        scope.Complete();
//                        message = ManageMessageId.RemoveLoginSuccess;
//                    }
//                }
//            }

//            return RedirectToAction("Manage", new { Message = message });
//        }

//        public ActionResult Manage(ManageMessageId? message)
//        {
//            ViewBag.StatusMessage =
//                message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
//                : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
//                : message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
//                : "";
//            ViewBag.HasLocalPassword = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
//            ViewBag.ReturnUrl = Url.Action("Manage");
//            return View();
//        }

//        [HttpPost]
//        //[ValidateAntiForgeryToken]
//        public ActionResult Manage(LocalPasswordModel model)
//        {
//            bool hasLocalAccount = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
//            ViewBag.HasLocalPassword = hasLocalAccount;
//            ViewBag.ReturnUrl = Url.Action("Manage");
//            if (hasLocalAccount)
//            {
//                if (ModelState.IsValid)
//                {
//                    // ChangePassword will throw an exception rather than return false in certain failure scenarios.
//                    bool changePasswordSucceeded;
//                    try
//                    {
//                        changePasswordSucceeded = WebSecurity.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword);
//                    }
//                    catch (Exception)
//                    {
//                        changePasswordSucceeded = false;
//                    }

//                    if (changePasswordSucceeded)
//                    {
//                        return RedirectToAction("Manage", new { Message = ManageMessageId.ChangePasswordSuccess });
//                    }
//                    else
//                    {
//                        ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
//                    }
//                }
//            }
//            else
//            {
//                // User does not have a local password so remove any validation errors caused by a missing
//                // OldPassword field
//                ModelState state = ModelState["OldPassword"];
//                if (state != null)
//                {
//                    state.Errors.Clear();
//                }

//                if (ModelState.IsValid)
//                {
//                    try
//                    {
//                        WebSecurity.CreateAccount(User.Identity.Name, model.NewPassword);
//                        return RedirectToAction("Manage", new { Message = ManageMessageId.SetPasswordSuccess });
//                    }
//                    catch (Exception e)
//                    {
//                        ModelState.AddModelError("", e);
//                    }
//                }
//            }

//            // If we got this far, something failed, redisplay form
//            return View(model);
//        }

//        #region Helpers
//        private ActionResult RedirectToLocal(string returnUrl)
//        {
//            if (Url.IsLocalUrl(returnUrl))
//            {
//                return Redirect(returnUrl);
//            }
//            else
//            {
//                return RedirectToAction("Index", "Home");
//            }
//        }

//        public enum ManageMessageId
//        {
//            ChangePasswordSuccess,
//            SetPasswordSuccess,
//            RemoveLoginSuccess,
//        }

//        internal class ExternalLoginResult : ActionResult
//        {
//            public ExternalLoginResult(string provider, string returnUrl)
//            {
//                Provider = provider;
//                ReturnUrl = returnUrl;
//            }

//            public string Provider { get; private set; }
//            public string ReturnUrl { get; private set; }

//            public override void ExecuteResult(ControllerContext context)
//            {
//                OAuthWebSecurity.RequestAuthentication(Provider, ReturnUrl);
//            }
//        }

//        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
//        {
//            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
//            // a full list of status codes.
//            switch (createStatus)
//            {
//                case MembershipCreateStatus.DuplicateUserName:
//                    return "User name already exists. Please enter a different user name.";

//                case MembershipCreateStatus.DuplicateEmail:
//                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

//                case MembershipCreateStatus.InvalidPassword:
//                    return "The password provided is invalid. Please enter a valid password value.";

//                case MembershipCreateStatus.InvalidEmail:
//                    return "The e-mail address provided is invalid. Please check the value and try again.";

//                case MembershipCreateStatus.InvalidAnswer:
//                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

//                case MembershipCreateStatus.InvalidQuestion:
//                    return "The password retrieval question provided is invalid. Please check the value and try again.";

//                case MembershipCreateStatus.InvalidUserName:
//                    return "The user name provided is invalid. Please check the value and try again.";

//                case MembershipCreateStatus.ProviderError:
//                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

//                case MembershipCreateStatus.UserRejected:
//                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

//                default:
//                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
//            }
//        }
//        #endregion
//    }
//}
