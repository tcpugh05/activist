using Activist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activist.Domain.Concrete;

namespace Activist.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Issues to go here!";
            EFPIssueRepository ef = new EFPIssueRepository();
            return View(ef);
        }

        public ViewResult Issue()
        {
            return View(new Contact());
        }

        [HttpPost]
        public ViewResult Issue(Contact contact){
            if (ModelState.IsValid)
            {
                return View("Completed", contact);
            } else {
                return View();
            }
        }
    }
}
