using Common.Models;

namespace Common.ClientType
{
    public interface IClientTypeRepository
    {
        ClientType Get(int id);
    }
}
