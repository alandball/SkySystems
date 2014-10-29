using System.Collections.Generic;
using Common.Models;

namespace Common.StockLogs
{
    public interface IStockLogService
    {
        List<StockLog> GetByBranch();
    }
}
