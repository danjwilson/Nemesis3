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

        StoreModelContext context = new StoreModelContext();

        public ActionResult List(string PostcodeDistrict)
        {
            if (PostcodeDistrict != null)
                return View(new StoreListViewModel(Store.GetStore(context).Where(s => s.Postcode.ToLower().StartsWith(PostcodeDistrict.ToLower()))));
            else
                return View(new StoreListViewModel(Store.GetStore(context)));
        }

                // Get for displaying specified store detail
        [HttpGet]
        public ActionResult Detail(string Id)
        {
            return View(new StoreDetailViewModel(Store.GetStore(context).First(s => s.Id.Equals(Id))));
        }

        
        // Post used for updating a store
        [HttpPost]
        public ActionResult Detail(StoreDetailViewModel model)
        //public ActionResult Detail(string Id)
        {
            if (model.Id != null && ModelState.IsValid)
            {
                // REVIEW:
                Store.Update(context, new Store(model.Name, model.Address, model.Postcode, model.OpeningHours, model.Id));
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StoreDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                // REVIEW:
                string newId = model.Name.ToLower().Replace(" ", String.Empty);
                Store.Create(context, new Store(model.Name, model.Address, model.Postcode, model.OpeningHours, newId));
                return RedirectToAction("Detail", "Store", new { Id = newId });
            }
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (context != null)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

