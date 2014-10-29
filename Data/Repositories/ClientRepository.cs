using System.Collections.Generic;
using System.Linq;
using Common.Clients;
using Common.Models;

namespace Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public List<Client> GetAll()
        {
            using (var db = new DataContext())
            {
                return db.Clients
                    .Include("ClientType")
                    .Where(x => x.IsDeleted == false).OrderBy(x => x.CompanyName).ToList();
            }
        }
    }
}
