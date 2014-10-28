using Common.Clients;

namespace UI.ViewModels.ViewModelBuilders
{
    public class ClientViewModelBuilder
    {
        private readonly IClientService _clientService;

        public ClientViewModelBuilder(IClientService clientService)
        {
            _clientService = clientService;
        }

        public ClientIndexViewModel BuildIndexViewModel()
        {
            var model = new ClientIndexViewModel
            {
                Clients = _clientService.GetAll()
            };

            return model;
        }
    }
}
