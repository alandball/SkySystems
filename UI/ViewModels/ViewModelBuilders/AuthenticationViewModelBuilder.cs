namespace UI.ViewModels.ViewModelBuilders
{
    public class AuthenticationViewModelBuilder
    {
        public AuthenticationCreateUpdateViewModel BuildCreateViewModel(int userId)
        {
            var model = new AuthenticationCreateUpdateViewModel
            {
                UserId = userId
            };

            return model;
        }
    }
}