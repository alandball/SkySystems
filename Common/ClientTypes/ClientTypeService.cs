using Common.Models;

namespace Common.ClientType
{
    public class ClientTypeService : IClientTypeService
    {
        private readonly IClientTypeRepository _clientTypeRepository;

        public ClienService(IClienRepository clientTypeRepository)
        {
            _clientTypeRepository = clientTypeRepository;
        }

        public ClientType Get(int id)
        {
            var clientType = _clientTypeRepository.Get(id);
            
            return clientType;
        }
    }
}
