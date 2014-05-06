using Activist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activist.Controllers
{
    public class HomeController : Controller
    {
        private IssueDBContext db = new IssueDBContext();

        public ActionResult Index()
        {
            return View(db.Issues.ToList());
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
