using Common.Models;

namespace Common.Stock
{
    public interface IStockRepository
    {
        Stock Get(int id);
    }
}
