using System.Collections.Generic;
using Common.Models;

namespace Common.StockLogs
{
    public class StockLogService : IStockLogService
    {
        private readonly IStockLogRepository _stockLogRepository;

        public StockLogService(IStockLogRepository stockLogRepository)
        {
            _stockLogRepository = stockLogRepository;
        }

        public List<StockLog> GetByBranch()
        {
            int branchId = 1;
            return _stockLogRepository.GetByBranch(branchId);
        }
    }
}
