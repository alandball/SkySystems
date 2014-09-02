using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Common.Models;

namespace Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        //public DbSet<Branch> Branches { get; set; }
        //public DbSet<UserType> UserTypes { get; set; }

        public DataContext()
            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
