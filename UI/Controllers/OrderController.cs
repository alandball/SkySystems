using System.Web.Mvc;
using Common.Orders;
using UI.ViewModels.ViewModelBuilders;

namespace UI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly OrderViewModelBuilder _viewModelBuilder;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
            _viewModelBuilder = new OrderViewModelBuilder(_orderService);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _viewModelBuilder.BuildIndexViewModel();
            return PartialView("IndexPartial", model);
        }
    }
}
