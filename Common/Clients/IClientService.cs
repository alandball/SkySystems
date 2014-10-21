using Common.Models;

namespace Common.Client
{
    public interface IClientRepository
    {
        Client Get(int id);
    }
}
