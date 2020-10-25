using ICA01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA01.Controllers
{
    public class OwnerController : Controller
    {
        private RealStateContext RealState = new RealStateContext();
        // GET: Owner
        public ActionResult Index()
        {
            List<Owner> Owners = RealState.Owners.ToList();
            return View(Owners);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Owner Owns)
        {
            RealState.Owners.Add(Owns);
            RealState.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(String id)
        {
            Owner Owners = RealState.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(Owners);
        }
        public ActionResult Edit(String id)
        {
            Owner Owners = RealState.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(Owners);
        }
        [HttpPost]
        public ActionResult Edit(String id, Owner UpdateOwns)
        {
            Owner Owners = RealState.Owners.SingleOrDefault(x => x.OwnerNo == id);
            Owners.Fname = UpdateOwns.Fname;
            Owners.Lname = UpdateOwns.Lname;
            Owners.Address = UpdateOwns.Address;
            Owners.telPhoneNumber = UpdateOwns.telPhoneNumber;
            RealState.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(String id)
        {
            Owner Ownerss = RealState.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View();
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult UpdateDelete(String id)
        {
            Owner Ownerss = RealState.Owners.SingleOrDefault(x => x.OwnerNo == id);
            RealState.Owners.Remove(Ownerss);
            RealState.SaveChanges();
            RedirectToAction("Index");

            return View();

        }
    }
}