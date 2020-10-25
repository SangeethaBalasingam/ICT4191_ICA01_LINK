using ICA01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA01.Controllers
{
    public class HomeController : Controller
    {
        private RealStateContext RealState = new RealStateContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //Fliter the Staff Based on thier postion
        public ActionResult FliterStaff()
        {
            List<Staff> AllStaffs = RealState.Staffs.ToList();
            return View(AllStaffs);
        }
        //Fliter the buliding based on their city
        public ActionResult FliterBuliding()
        {
            List<Rent> AllRents = RealState.Rents.ToList();
            return View(AllRents);
        }
        public ActionResult BranchCount(String id)
        {
            var rent = RealState.Rents.Where(x => x.RefBranchNo == id).ToList();
            ViewBag.count = rent;
            return View();
        }
    }
}