using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nemesis.Core;
using Nemesis.Site.Models;

namespace Nemesis.Site.Controllers
{
    public class StoreController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(string PostcodeDistrict)
        {
            if (PostcodeDistrict != null)
                return View(new StoreListViewModel(StoreSamples.SampleStores.Where(s => s.Postcode.ToLower().StartsWith(PostcodeDistrict.ToLower()))));
            else
                //return View(new StoreListViewModel(StoreSamples.SampleStores));
                return View(new StoreListViewModel(Store.GetStore(new StoreModelContext())));
        }

        public ActionResult Detail(string Id)
        {
            return View(new StoreDetailViewModel(StoreSamples.SampleStores.First(s => s.Id.Equals(Id))));
        }
    }
}

