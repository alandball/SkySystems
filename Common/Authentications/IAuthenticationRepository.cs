using Common.Models;

namespace Common.Authentications
{
    public interface IAuthenticationRepository
    {
        int Create(Authentication authentication);
        void Update(Authentication dbRecord);
        Authentication GetByUsername(string username);
    }
}
