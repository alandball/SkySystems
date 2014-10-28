using System.Web.Mvc;
using Common.Clients;
using UI.ViewModels.ViewModelBuilders;

namespace UI.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        private readonly ClientViewModelBuilder _viewModelBuilder;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
            _viewModelBuilder = new ClientViewModelBuilder(_clientService);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _viewModelBuilder.BuildIndexViewModel();
            return PartialView("IndexPartial", model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            throw new System.NotImplementedException();
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
    }
}
