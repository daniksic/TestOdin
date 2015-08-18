using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestOdin.Data;
using TestOdin.Models;

namespace TestOdin.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            var tasks = UoW.Instance().Tasks().GetAll();
            return View(tasks);
        }

        [ChildActionOnly]
        public ActionResult TaskPartial()
        {
            var tasks = UoW.Instance().Tasks().GetAll();
            return PartialView("_TasksPartial", tasks);
        }

        [ChildActionOnly]
        public ActionResult CreatePartial()
        {
            return PartialView("_CreatePartial", new Task());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public void CreatePartial(Task task) {

            task.Id = UoW.Instance().Tasks().GetAll().Count() + 1;
            task.DateAdded = DateTime.Now;

            UoW.Instance().Tasks().Add(task);

            ControllerContext.HttpContext.Response.Redirect(ControllerContext.HttpContext.Request.Url.ToString());
        }
    }
}