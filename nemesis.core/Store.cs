using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace Nemesis.Core
{
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
            return context.Stores.AsQueryable();
        }

        public static void Create(StoreModelContext context, Store store)
        {
            context.Stores.Add(store);
            context.SaveChanges();
        }

        public static void Update(StoreModelContext context, Store store)
        {
            context.Entry(store).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
