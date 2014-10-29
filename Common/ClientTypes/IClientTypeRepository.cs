using System.Collections.Generic;
using Common.Models;

namespace Common.ClientTypes
{
    public interface IClientTypeRepository
    {
        List<ClientType> GetAll();
    }
}
