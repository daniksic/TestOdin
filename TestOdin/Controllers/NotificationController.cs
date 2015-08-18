using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestOdin.Data;

namespace TestOdin.Controllers
{
    public class NotificationController : Controller
    {
        // GET: Notification
        public ActionResult Index()
        {
            var data = UoW.Instance().Notifications().GetAll();
            return View(data);
        }

        [ChildActionOnly]
        public ActionResult NotificationPartial()
        {
            var data = UoW.Instance().Notifications().GetAll();
            return PartialView("_NotificationPartial", data);
        }
    }
}