using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nemesis.Core;

namespace Nemesis.Site.Models
{
    public class StoreDetailViewModel
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Postcode { get; set; }

        public string OpeningHours { get; set; }

        public string Id { get; set; }

        public StoreDetailViewModel() { }

        public StoreDetailViewModel(Store store)
        {
            Name = store.Name;
            Address = store.Address;
            Postcode = store.Postcode;
            OpeningHours = store.OpeningHours;
            Id = store.Id;
        }
    }
}