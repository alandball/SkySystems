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

            if (authentication.Id == 0)
            {
                authentication.DateCreated = now;
                authentication.UserIdCreatedBy = userId;

                return _authenticationRepository.Create(authentication);
            }
            else
            {
                var dbRecord = Get(authentication.UserName, authentication.Password);

                dbRecord.UserName = authentication.UserName;
                dbRecord.Password = authentication.Password;

                dbRecord.DateLastModified = now;
                dbRecord.UserIdLastModifiedBy = userId;

                _authenticationRepository.Update(dbRecord);

                return authentication.Id;
            }
        }

        public Authentication Get(string username, string password)
        {
            return _authenticationRepository.Get(username, password);
        }
    }
}
