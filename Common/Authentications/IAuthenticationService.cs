using Common.Models;

namespace Common.Authentications
{
    public interface IAuthenticationService
    {
        int CreateUpdate(Authentication authentication);
        Authentication GetByUsername(string username);
    }
}
