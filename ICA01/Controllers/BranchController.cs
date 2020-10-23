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
            return Redirect("Index");
        }
        public ActionResult Details(String BId)
        {
            Branch Branches = RealState.Branchs.SingleOrDefault(x => x.BranchNo == BId);
            return View(Branches);
        }
        public ActionResult Edit(String BId)
        {
            Branch Branches = RealState.Branchs.SingleOrDefault(x => x.BranchNo == BId);
            return View(Branches);
           // return View();
        }
        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }
    }
}