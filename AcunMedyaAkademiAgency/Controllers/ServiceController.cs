﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Context;
using AcunMedyaAkademiAgency.Entities;
using Newtonsoft.Json.Linq;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class ServiceController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult ServiceList()
        {
            var values = context.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(Service service)
        {
            context.Services.Add(service);
            context.SaveChanges();

            return RedirectToAction("ServiceList");
        }
        public ActionResult DeleteService(int ID)
        {
            var value = context.Services.Find(ID);
            context.Services.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public ActionResult UpdateService(int ID)
        {
            var value = context.Services.Find(ID);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(Service service)
        {
            var value = context.Services.Find(service.ServiceID);
            value.Title = service.Title;
            value.ImageUrl = service.ImageUrl;
            value.Description = service.Description;
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
    }
}