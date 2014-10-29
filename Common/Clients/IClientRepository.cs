using System.Collections.Generic;
using Common.Models;

namespace Common.Clients
{
    public interface IClientService
    {
        List<Client> GetAll();
        int CreateUpdate(Client client);
    }
}
