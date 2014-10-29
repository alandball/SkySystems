using System.Collections.Generic;
using Common.Models;

namespace Common.ClientTypes
{
    public class ClientTypeService : IClientTypeService
    {
        private readonly IClientTypeRepository _clientTypeRepository;

        public ClientTypeService(IClientTypeRepository clientTypeRepository)
        {
            _clientTypeRepository = clientTypeRepository;
        }

        public List<ClientType> GetAll()
        {
            return _clientTypeRepository.GetAll();
        }
    }
}
