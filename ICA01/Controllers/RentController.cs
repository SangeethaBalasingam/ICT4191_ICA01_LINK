using ICA01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA01.Controllers
{
   
    public class RentController : Controller
    {
        private RealStateContext RealState = new RealStateContext();
        // GET: Rent
        public ActionResult Index()
        {
            List<Rent> AllRents = RealState.Rents.ToList();
            return View(AllRents);
        }
        public ActionResult Create()
        {
            ViewBag.Rents = new SelectList(RealState.Owners, "OwnerNo", "Address");
            ViewBag.Stafs = new SelectList(RealState.Staffs, "StaffNo", "Position");
            ViewBag.Bran = new SelectList(RealState.Branchs, "BranchNo", "Street");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Rent Rentes)
        {
            ViewBag.Rents = new SelectList(RealState.Owners, "OwnerNo", "Address");
            ViewBag.Stafs = new SelectList(RealState.Staffs, "StaffNo", "Position");
            ViewBag.Bran = new SelectList(RealState.Branchs, "BranchNo", "Street");
            RealState.Rents.Add(Rentes);
            RealState.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(String id)
        {
            Rent Rents = RealState.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(Rents);
        }
        public ActionResult Edit(String id)
        {
            ViewBag.Rents = new SelectList(RealState.Owners, "OwnerNo", "Address");
            ViewBag.Stafs = new SelectList(RealState.Staffs, "StaffNo", "Position");
            ViewBag.Bran = new SelectList(RealState.Branchs, "BranchNo", "Street");
            Rent Rents = RealState.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(Rents);
        }
        [HttpPost]
        public ActionResult Edit(String id, Rent UpdateRentes)
        {
            Rent Rents = RealState.Rents.SingleOrDefault(x => x.PropertyNo == id);
            Rents.Street = UpdateRentes.Street;
            Rents.City = UpdateRentes.City;
            Rents.Ptype = UpdateRentes.Ptype;
            Rents.Rooms = UpdateRentes.Rooms;
            Rents.RefOwnernumber = UpdateRentes.RefOwnernumber;
            Rents.RefStaffNo = UpdateRentes.RefStaffNo;
            Rents.RefBranchNo = UpdateRentes.RefBranchNo;
            RealState.SaveChanges();
            return RedirectToAction("Index");
            
        }
        public ActionResult Delete(String id)
        {
            Rent Rents = RealState.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(Rents);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteRent(String id)
        {
            Rent Rents = RealState.Rents.SingleOrDefault(x => x.PropertyNo == id);
            RealState.Rents.Remove(Rents);
            RealState.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}