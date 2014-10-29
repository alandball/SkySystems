using System.Collections.Generic;
using Common.Models;

namespace Common.Orders
{
    public interface IOrderService
    {
        List<Order> GetByBranch();
    }
}
