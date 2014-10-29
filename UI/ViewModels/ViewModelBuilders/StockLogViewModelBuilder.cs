using System.Linq;
using Common.StockLogs;

namespace UI.ViewModels.ViewModelBuilders
{
    public class StockLogViewModelBuilder
    {
        private readonly IStockLogService _stockLogService;

        public StockLogViewModelBuilder(IStockLogService stockLogService)
        {
            _stockLogService = stockLogService;
        }

        public StockLogIndexViewModel BuildIndexViewModel()
        {
            var stockLogs = _stockLogService.GetByBranch();

            var quantity = stockLogs.Sum(stockLog => (int) stockLog.InOut);

            var model = new StockLogIndexViewModel
            {
                StockLogs = stockLogs,
                Quantity = quantity
            };

            return model;
        }
    }
}