using Common.Clients;
using Common.ClientTypes;

namespace UI.ViewModels.ViewModelBuilders
{
    public class DashboardViewModelBuilder
    {
        private readonly IClientService _clientService;
        private readonly IClientTypeService _clientTypeService;

        public DashboardViewModelBuilder(IClientService clientService, IClientTypeService clientTypeService)
        {
            _clientService = clientService;
            _clientTypeService = clientTypeService;
        }

        public DashboardClientCreateUpdateViewModel BuildCreateViewModel(int userId)
        {
            var clientTypes = _clientTypeService.GetAll();

            var model = new DashboardClientCreateUpdateViewModel
            {
                UserId = userId,
                ClientTypes = clientTypes
            };

            return model;
        }
    }
}