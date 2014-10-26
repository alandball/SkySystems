using System;
using Common.Models;
using Common.Users;

namespace Common.Authentications
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _authenticationRepository;
        private readonly IUserService _userService;

        public AuthenticationService(IAuthenticationRepository authenticationRepository, IUserService userService)
        {
            _authenticationRepository = authenticationRepository;
            _userService = userService;
        }

        public int CreateUpdate(Authentication authentication)
        {
            var userId = 2;
            var now = DateTime.Now;

            if (GetByUsername(authentication.UserName) != null)
            {
                if (authentication.Id == 0)
                {
                    authentication.DateCreated = now;
                    authentication.UserIdCreatedBy = userId;

                    return _authenticationRepository.Create(authentication);
                }

                var dbRecord = GetByUsername(authentication.UserName);

                dbRecord.UserName = authentication.UserName;
                dbRecord.Password = authentication.Password;

                dbRecord.DateLastModified = now;
                dbRecord.UserIdLastModifiedBy = userId;

                _authenticationRepository.Update(dbRecord);

                return authentication.Id;
            }

            return 0;
        }

        public Authentication GetByUsername(string username)
        {
            return _authenticationRepository.GetByUsername(username);
        }
    }
}
