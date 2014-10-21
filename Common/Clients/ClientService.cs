using Common.Models;

namespace Common.Client
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client Get(int id)
        {
            var client = _clientRepository.Get(id);
            
            return client;
        }
    }
}
