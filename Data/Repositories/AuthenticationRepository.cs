using System.Data.Entity;
using System.Linq;
using Common.Authentications;
using Common.Models;

namespace Data.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        public int Create(Authentication authentication)
        {
            using (var db = new DataContext())
            {
                db.Authentications.Add(authentication);
                db.SaveChanges();

                return authentication.Id;
            }
        }

        public void Update(Authentication dbRecord)
        {
            using (var db = new DataContext())
            {
                db.Entry(dbRecord).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Authentication GetByUsername(string username)
        {
            using (var db = new DataContext())
            {
                return db.Authentications
                    .Include("User")
                    .SingleOrDefault(x => x.UserName == username && x.IsDeleted == false);
            }
        }
    }
}
