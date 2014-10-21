using Common.Models;

namespace Common.Stock
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public Stock Get(int id)
        {
            var stock = _stockRepository.Get(id);
            
            return stock;
        }
    }
}
