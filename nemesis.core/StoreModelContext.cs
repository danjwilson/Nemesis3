using System;
using System.Data.Entity;

namespace Nemesis.Core
{
    public class StoreModelContext : DbContext
    {
        public DbSet<Store> Store { get; set; }
    }
}
