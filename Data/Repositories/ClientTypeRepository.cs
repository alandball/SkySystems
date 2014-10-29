using System.Collections.Generic;
using System.Linq;
using Common.ClientTypes;
using Common.Models;

namespace Data.Repositories
{
    public class ClientTypeRepository : IClientTypeRepository
    {
        public List<ClientType> GetAll()
        {
            using (var db = new DataContext())
            {
                return db.ClientTypes.ToList();
            }
        }
    }
}
