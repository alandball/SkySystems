using Common.Orders;

namespace UI.ViewModels.ViewModelBuilders
{
    public class OrderViewModelBuilder
    {
        private readonly IOrderService _orderService;

        public OrderViewModelBuilder(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public OrderIndexViewModel BuildIndexViewModel()
        {
            var model = new OrderIndexViewModel
            {
                Orders = _orderService.GetByBranch()
            };

            return model;
        }
    }
}
