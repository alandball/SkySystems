using System.Collections.Generic;
using Common.Models;

namespace Common.StockLogs
{
    public interface IStockLogRepository
    {
        List<StockLog> GetByBranch(int branchId);
    }
}
