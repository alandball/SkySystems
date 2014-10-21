using Common.Models;

namespace Common.Address
{
    public interface IAddressRepository
    {
        Address Get(int id);
    }
}
