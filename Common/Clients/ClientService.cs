using System.Collections.Generic;
using Common.Models;

namespace Common.Clients
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }
    }
}
