using Common.StockLogs;

namespace UI.ViewModels.ViewModelBuilders
{
    public class StockLogViewModelBuilder
    {
        private readonly IStockLogService _stockService;

        public StockLogViewModelBuilder(IStockLogService stockService)
        {
            _stockService = stockService;
        }

        public StockLogIndexViewModel BuildIndexViewModel()
        {
            var model = new StockLogIndexViewModel();
            {
                
            };

            return model;
        }
    }
}