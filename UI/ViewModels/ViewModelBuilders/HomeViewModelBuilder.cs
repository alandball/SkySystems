using Common.Authentications;
using Common.Users;

namespace UI.ViewModels.ViewModelBuilders
{
    public class HomeViewModelBuilder
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;

        public HomeViewModelBuilder( IUserService userService)
        {

            _userService = userService;
        }

        public HomeIndexViewModel BuildIndexViewModel()
        {
            throw new System.NotImplementedException();
        }
    }
}