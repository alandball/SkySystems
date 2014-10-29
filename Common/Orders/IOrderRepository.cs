using System.Collections.Generic;
using Common.Models;

namespace Common.Orders
{
    public interface IOrderRepository
    {
        List<Order> GetByBranch(int branchId);
    }
}
