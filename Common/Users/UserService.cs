using Common.Models;

namespace Common.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Get(int id)
        {
            var user = _userRepository.Get(id);
            
            return user;
        }
    }
}
