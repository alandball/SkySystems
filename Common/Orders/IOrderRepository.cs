using Common.Models;

namespace Common.Order
{
    public interface IOrderRepository
    {
        Order Get(int id);
    }
}
