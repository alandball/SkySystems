using Common.Models;

namespace Common.Address
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public Address Get(int id)
        {
            var address = _addressRepository.Get(id);
            
            return address;
        }
    }
}
