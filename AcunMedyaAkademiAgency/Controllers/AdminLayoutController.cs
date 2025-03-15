using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Context;
using AcunMedyaAkademiAgency.Entities;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class AdminLayoutController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HeadPartial()
        {
            return PartialView();
        }
        public ActionResult SidebarPartial()
        {
            var username = Session["username"];
            var namesurname = context.Admins.Where(x => x.UserName == username).Select(x => x.Name + " " + x.SurName).FirstOrDefault();
            ViewBag.profile = namesurname;           
            return PartialView();
        }
        public ActionResult NavbarPartial()
        {
            var username = Session["username"];
            var namesurname = context.Admins.Where(x=>x.UserName == username).Select(x=>x.Name + " " + x.SurName).FirstOrDefault();
            ViewBag.profile = namesurname;
            return PartialView();
        }
        public ActionResult NotificationPartial()
        {
            var values = context.Notifications.ToList();
            return PartialView(values);
        }
        public ActionResult FooterPartial()
        {
            return PartialView();
        }
        public ActionResult ScriptsPartial()
        {
            return PartialView();
        }
        public ActionResult MessagePartial()
        {
            var values = context.Messages.ToList();
            return PartialView(values);
        }
    }
}