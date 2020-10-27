using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelApplication.Models;

namespace TravelApplication.Controllers
{
    public class LocationController : Controller
    {
        ServiceClient serviceClient = new ServiceClient();
        // GET: Location
        public ActionResult Index()
        {
            ViewBag.listLocation = serviceClient.getAllLocation();
            return View();
        }

        // GET: Location/Details/5
        public ActionResult Details(int id)
        {
            var location = serviceClient.getAllLocation().Where(b => b.id == id).FirstOrDefault();

            return View(location);
        }

        // GET: Location/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Location location)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    serviceClient.AddLocation(location);
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int id)
        {
            var location = serviceClient.getAllLocation().Where(b => b.id == id).FirstOrDefault();

            return View(location);
        }

        // POST: Location/Edit/5
        [HttpPost]
        public ActionResult Edit(Location newlocation)
        {
            try
            {
                // TODO: Add update logic here
                serviceClient.EditLocation(newlocation);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Delete/5
        public ActionResult Delete(string id)
        {
            serviceClient.DeleteLocation(id);
            return View();
        }

        // POST: Location/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
