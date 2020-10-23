using ICA01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA01.Controllers
{
    public class StaffController : Controller
    {
        private RealStateContext RealState = new RealStateContext();
        // GET: Staff
        public ActionResult Index()
        {
            List<Staff> AllStaffs = RealState.Staffs.ToList();
            return View(AllStaffs);
        }
        public ActionResult Create()
        {
            ViewBag.Braninfro = RealState.Branchs;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Staff Staf)
        {
            ViewBag.Braninfro = RealState.Branchs;
            RealState.Staffs.Add(Staf);
            RealState.SaveChanges();
            return RedirectToAction("Index");
            
        }
        public ActionResult Details(String id)
        {
            Staff Stafs = RealState.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(Stafs);
        }
        public ActionResult Update(String id)
        {
            ViewBag.Branchin = new SelectList(RealState.Branchs, "BranchNo", "Street", "Branchref");
            Staff Stafs = RealState.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(Stafs);
            
        }
        [HttpPost]
        public ActionResult Update()
        {
            return View();
        }

    }
}