using AcunMedyaAkademiAgency.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class DashboardController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult Index()
        {
            ViewBag.bildirimsayisi = context.Notifications.ToList().Count;
            ViewBag.projesayisi = context.Projects.ToList().Count;
            int CategoryWeb = context.Categories.Where(x => x.CategoryName == "Web").Select(y=>y.CategoryID).FirstOrDefault();
            ViewBag.WebCount = context.Projects.Where(x=>x.CategoryID == CategoryWeb).Count();
            ViewBag.personelsayisi = context.Teams.ToList().Count;
            return View();
        }
        public PartialViewResult StaffPartial()
        {
            var values = context.Teams.ToList();
            return PartialView(values);
        }
    }
}