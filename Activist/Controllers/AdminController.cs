using Activist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activist.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        private IssueDBContext db = new IssueDBContext();

        public ActionResult Index()
        {
            return View(db.Issues.ToList());
        }

        public ViewResult Edit(int id)
        {
            Issue issue = db.Issues
                .FirstOrDefault(p => p.Id == id);
            return View(issue);
        }

        public ViewResult Create()
        {
            return View("Edit", new Issue());
        }

        [HttpPost]
        public ActionResult Edit(Issue product, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                //TODO: Save here. old code was repository.SaveProduct(product)
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(product);
            }
        }


        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Issue deletedProduct; //TODO: Delete. Old code was: db.DeleteProduct(productId);
            return RedirectToAction("Index");
        }

    }
}
