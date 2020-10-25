using ICA01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA01.Controllers
{
    public class BranchController : Controller
    {
        private RealStateContext RealState = new RealStateContext();
        // GET: Branch
        public ActionResult Index()
        {
            List<Branch> Branches = RealState.Branchs.ToList();
            return View(Branches);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Branch Branches)
        {
            RealState.Branchs.Add(Branches);
            RealState.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details( String id)
        {
            Branch branches = RealState.Branchs.SingleOrDefault(x => x.BranchNo == id);
            return View(branches);
        }
        public ActionResult Edit(String id)
        {
            Branch branches = RealState.Branchs.SingleOrDefault(x => x.BranchNo == id);
            return View(branches);
        }
        [HttpPost]
        public ActionResult Edit(String id, Branch UpdateBranches)
        {
            Branch branches = RealState.Branchs.SingleOrDefault(x => x.BranchNo == id);
            branches.Street = UpdateBranches.Street;
            branches.City = UpdateBranches.City;
            branches.PostCode = UpdateBranches.PostCode;
            RealState.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(String id)
        {
            Branch branches = RealState.Branchs.SingleOrDefault(x => x.BranchNo == id);
            return View();
        }
        [HttpPost,ActionName("DeleteBranch")]
        public ActionResult DeleteBranch(String id)
        {
            Branch branches = RealState.Branchs.SingleOrDefault(x => x.BranchNo == id);
            RealState.Branchs.Remove(branches);
            RealState.SaveChanges();
            return RedirectToAction("Index");
        }
        
       
    }
}