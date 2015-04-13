using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

namespace Nemesis.Core
{
    public static class StoreSamples
    {
        public static IQueryable<Store> SampleStores = new List<Store>
        {
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
        }.AsQueryable();
    }

    public class Store
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Postcode { get; set; }

        public string OpeningHours { get; set; }

        [Key]
        public string Id { get; set; }

        public Store()
        { }

        public Store(string name, string address, string postcode, string openingHours, string id)
        {
            Name = name;
            Address = address;
            Postcode = postcode;
            OpeningHours = openingHours;
            Id = id;
        }

        //public static IQueryable<Store> GetStore()
        //{
        //    using (var context = new StoreModelContext())
        //    {
        //        return context.Store.AsQueryable();
        //    }
        //}

        public static IQueryable<Store> GetStore(StoreModelContext context)
        {
            return context.Store.AsQueryable();
        }

    }
}
