using System.Web.Mvc;
using Common.Clients;
using Common.ClientTypes;
using Common.Models;
using Omu.ValueInjecter;
using UI.ViewModels;
using UI.ViewModels.ViewModelBuilders;

namespace UI.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IClientTypeService _clientTypeService;
        private readonly ClientViewModelBuilder _viewModelBuilder;

        public ClientController(IClientService clientService, IClientTypeService clientTypeService)
        {
            _clientService = clientService;
            _clientTypeService = clientTypeService;
            _viewModelBuilder = new ClientViewModelBuilder(_clientService, _clientTypeService);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _viewModelBuilder.BuildIndexViewModel();
            return PartialView("IndexPartial", model);
        }

        [HttpGet]
        public ActionResult Create(int userId)
        {
            var model = _viewModelBuilder.BuildCreateViewModel(userId);
            return PartialView("CreateUpdatePartial", model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            throw new System.NotImplementedException();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        [HttpPost]
        public ActionResult CreateUpdate(ClientIndexViewModel model)
        {
            var client = new Client();
            client.InjectFrom(model);

            _clientService.CreateUpdate(client);

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
