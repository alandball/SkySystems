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

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll(1);
        }
    }
}
