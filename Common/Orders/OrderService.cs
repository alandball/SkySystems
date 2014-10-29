using System.Collections.Generic;
using Common.Models;

namespace Common.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;

        }

        public List<Order> GetByBranch()
        {
            return _orderRepository.GetByBranch(1);
        }
    }
}
