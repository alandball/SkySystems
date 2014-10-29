using System;
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

        public Client Get(int id)
        {
            return _clientRepository.Get(id);
        }

        public int CreateUpdate(Client client)
        {
            var userId = 2;
            var now = DateTime.Now;

            if (client.Id == 0)
            {
                client.DateCreated = now;
                client.UserIdCreatedBy = userId;

                return _clientRepository.Create(client);
            }
            else
            {
                var dbRecord = Get(client.Id);

                dbRecord.CompanyName = client.CompanyName;
                dbRecord.Email = client.Email;

                dbRecord.Tel1 = client.Tel1;
                dbRecord.Tel2 = client.Tel2;

                dbRecord.DateLastModified = now;
                dbRecord.UserIdLastModifiedBy = userId;

                _clientRepository.Update(dbRecord);

                return client.Id;
            }
        }
    }
}
