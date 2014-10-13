using Common.Models;

namespace Common.Order
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order Get(int id)
        {
            var order = _orderRepository.Get(id);
            
            return order;
        }
    }
}
