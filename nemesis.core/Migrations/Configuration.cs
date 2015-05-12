namespace Nemesis.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Nemesis.Core.StoreModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Nemesis.Core.StoreModelContext";
        }

        protected override void Seed(Nemesis.Core.StoreModelContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Stores.AddOrUpdate(s => s.Name,
                new Store("Dave's Fish Shop", "Some address", "SE1 0BH", "TBC", "davesfish"),
                new Store("ABC Fabrics", "Some address", "SE1 5BD", "TBC", "abcfabrics"),
                new Store("ACDC Electical Supplies", "Some address", "SE1 6HD", "TBC", "acdc"),
                new Store("Pat's Pet Food", "Some address", "SE1 3NH", "TBC", "patspet"),
                new Store("Southwark Convenience Store", "Some address", "SE1 2BB", "TBC", "swarkconv"),
                new Store("The DIY Store", "Some address", "W14 4UK", "TBC", "diystore"),
                new Store("Jenny's Books", "Some address", "W14 2WE", "TBC", "jennysbooks"),
                new Store("Ye Olde Pie Shop", "Some address", "W14 1DS", "TBC", "yeoldepie"),
                new Store("Harvey Florist", "Some address", "W14 3XX", "TBC", "harveyflorist"),
                new Store("Hammersmith Tattoo", "Some address", "SE1 0BH", "TBC", "hammersmithtattoo"),
                new Store("Bethnal Coffee Supplies", "Some address", "E2 2EE", "TBC", "bethnalcoffee"),
                new Store("A&A Food Mart", "Some address", "E2 6HD", "TBC", "aafood"),
                new Store("Fashion Warehouse", "Some address", "SE3 3NH", "TBC", "fashionwarehouse")
            );
        }
    }
}
