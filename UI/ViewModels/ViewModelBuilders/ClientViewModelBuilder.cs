using Common.Clients;
using Common.ClientTypes;

namespace UI.ViewModels.ViewModelBuilders
{
    public class ClientViewModelBuilder
    {
        private readonly IClientService _clientService;
        private readonly IClientTypeService _clientTypeService;

        public ClientViewModelBuilder(IClientService clientService, IClientTypeService clientTypeService)
        {
            _clientService = clientService;
            _clientTypeService = clientTypeService;
        }

        public ClientIndexViewModel BuildIndexViewModel(int? userId)
        {
            var clientTypes = _clientTypeService.GetAll();

            var model = new ClientIndexViewModel
            {
                Clients = _clientService.GetAll(),
                ClientTypes = clientTypes
            };

            if (userId.HasValue)
            {
                model.UserId = userId.Value;
            }

            return model;
        }

        public ClientCreateUpdateViewModel BuildCreateViewModel(int userId)
        {
            var clientTypes = _clientTypeService.GetAll();

            var model = new ClientCreateUpdateViewModel
            {
                UserId = userId,
                ClientTypes = clientTypes
            };

            return model;
        }
    }
}
