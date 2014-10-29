using System.Collections.Generic;
using System.Linq;
using Common.Models;
using Common.StockLogs;

namespace Data.Repositories
{
    public class StockLogRepository : IStockLogRepository
    {
        public List<StockLog> GetByBranch(int branchId)
        {
            using (var db = new DataContext())
            {
                return db.StockLogs
                    .Include("Branch")
                    .Where(x =>x.BranchId == branchId && x.IsDeleted == false).OrderByDescending(x => x.DateCreated).ToList();
            }
        }
    }
}
