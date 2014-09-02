using Common.Models;

namespace Common.Users
{
    public interface IUserRepository
    {
        User Get(int id);
    }
}
