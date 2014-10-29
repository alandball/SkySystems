using System.Collections.Generic;
using Common.Models;

namespace Common.Clients
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        int Create(Client client);
        Client Get(int id);
        void Update(Client dbRecord);
    }
}
