using System.Collections.Generic;
using Common.Models;

namespace Common.Clients
{
    public interface IClientRepository
    {
        List<Client> GetAll();
    }
}
