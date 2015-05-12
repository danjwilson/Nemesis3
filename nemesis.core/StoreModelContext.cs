using System;
using System.Data.Entity;

namespace Nemesis.Core
{
    public class StoreModelContext : DbContext
    {
        public StoreModelContext()
        {
            // REVIEW: Added to force the re-seeding of the database everytime
            //Database.SetInitializer<StoreModelContext>(new CreateDatabaseIfNotExists<StoreModelContext>());
        }

        public DbSet<Store> Stores { get; set; }
    }
}
