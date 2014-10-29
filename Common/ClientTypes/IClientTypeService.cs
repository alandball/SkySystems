using System.Collections.Generic;
using Common.Models;

namespace Common.ClientTypes
{
    public interface IClientTypeService
    {
        List<ClientType> GetAll();
    }
}
