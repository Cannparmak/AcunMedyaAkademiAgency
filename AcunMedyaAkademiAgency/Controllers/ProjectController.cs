using AcunMedyaAkademiAgency.Context;
using AcunMedyaAkademiAgency.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json.Linq;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class ProjectController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult ProjectList(String SearchText)
        {
            List<Project> values;
            if(SearchText != null)
            {
                values = context.Projects.Where(x=>x.Title.Contains(SearchText)).ToList();
                return View(values);
            }

            values = context.Projects.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            List<SelectListItem> values1 = (from x in context.Categories.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryID.ToString()
                                            }).ToList();
            ViewBag.v = values1;

            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(Project Project)
        {
            context.Projects.Add(Project);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        public ActionResult DeleteProject(int ID)
        {
            var value = context.Projects.Find(ID);
            context.Projects.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        [HttpGet]
        public ActionResult UpdateProject(int ID)
        {
            List<SelectListItem> values1 = (from x in context.Categories.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryID.ToString()
                                            }).ToList();
            ViewBag.v = values1;
            var value = context.Projects.Find(ID);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProject(Project Project)
        {
            var value = context.Projects.Find(Project.ProjectID);
            value.ImageUrl = Project.ImageUrl;
            value.Title = Project.Title;
            value.CategoryID = Project.CategoryID;
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
    }
}