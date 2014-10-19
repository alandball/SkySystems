using Common.Models;

namespace Common.Users
{
    public interface IUserService
    {
        User Get(int getUserId);
    }
}
