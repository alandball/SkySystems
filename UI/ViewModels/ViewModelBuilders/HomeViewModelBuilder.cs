using Common.Authentications;
using Common.Users;

namespace UI.ViewModels.ViewModelBuilders
{
    public class HomeViewModelBuilder
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;

        public HomeViewModelBuilder(IAuthenticationService authenticationService, IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;
        }

        public HomeIndexViewModel BuildIndexViewModel()
        {
            throw new System.NotImplementedException();
        }
    }
}