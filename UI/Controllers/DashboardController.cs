using System.Web.Mvc;
using Common.Clients;
using Common.ClientTypes;
using UI.ViewModels.ViewModelBuilders;

namespace UI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IClientTypeService _clientTypeService;
        private readonly DashboardViewModelBuilder _viewModelBuilder;

        public DashboardController(IClientService clientService, IClientTypeService clientTypeService)
        {
            _clientService = clientService;
            _clientTypeService = clientTypeService;
            _viewModelBuilder = new DashboardViewModelBuilder(_clientService, _clientTypeService);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}