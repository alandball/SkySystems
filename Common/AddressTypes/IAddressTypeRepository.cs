using Common.Models;

namespace Common.AddressType
{
    public interface IAddressTypeRepository
    {
        AddressType Get(int id);
    }
}
