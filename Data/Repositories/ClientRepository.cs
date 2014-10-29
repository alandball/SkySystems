using System.Collections.Generic;
using System.Data.Entity;
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

        public int Create(Client client)
        {
            using (var db = new DataContext())
            {
                db.Clients.Add(client);
                db.SaveChanges();

                return client.Id;
            }
        }

        public Client Get(int id)
        {
            using (var db = new DataContext())
            {
                return db.Clients
                    .Include("ClientType")
                    .Single(x => x.Id == id);
            }
        }

        public void Update(Client dbRecord)
        {
            using (var db = new DataContext())
            {
                db.Entry(dbRecord).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
