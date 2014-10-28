using System.Collections.Generic;
using System.Linq;
using Common.Models;
using Common.Orders;

namespace Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAll(int branchId)
        {
            using (var db = new DataContext())
            {
                return db.Orders.Where(x => x.BranchId == branchId && x.IsDeleted == false).OrderByDescending(x => x.DateCreated).ToList();
            }
        }
    }
}
