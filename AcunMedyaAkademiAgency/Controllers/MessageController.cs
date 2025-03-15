using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Entities;
using AcunMedyaAkademiAgency.Context;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class MessageController : Controller
    {
        AgencyContext context = new AgencyContext();

        public ActionResult MessageList(string searchText)
        {
            List<Message> values = new List<Message>();
            if (!string.IsNullOrEmpty(searchText))
            {
                values = context.Messages.Where(x => x.NameSurname.Contains(searchText)).ToList();
            }
            else
            {
                values = context.Messages.ToList();
            }

            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateIsRead(int messageId, bool isRead)
        {
            var message = context.Messages.Find(messageId);
            if (message != null)
            {
                message.IsRead = isRead;
                context.SaveChanges();
            }
            return Json(new { success = true });
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        [HttpGet]
        public ActionResult CreateMessage()
        {
            return View();
        }

 
        [HttpPost]
        public ActionResult CreateMessage(Message message)
        {
            message.IsRead = false; 
            message.SendDate = DateTime.Now; 
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }
    }
}