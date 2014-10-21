using System.Linq;
using Common.Models;
using Common.Users;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User Get(int id)
        {
            using (var db = new DataContext())
            {
                return db.Users
                         .Include("Branch")
                         .Include("UserType")
                         .Single(x => x.Id == id);
            }
        }
    }
}
