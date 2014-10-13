using Common.Models;

namespace Common.AddressType
{
    public class AddressTypeService : IAddressTypeService
    {
        private readonly IAddressTypeRepository _addressTypeRepository;

        public AddressTypeService(IAddressTypeRepository addressTypeRepository)
        {
            _addressTypeRepository = addressTypeRepository;
        }

        public AddressType Get(int id)
        {
            var addressType = _addressTypeRepository.Get(id);
            
            return addressType;
        }
    }
}
