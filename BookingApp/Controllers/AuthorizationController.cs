using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingApp.Controllers
{
    
    public class AuthorizationController : Controller
    {
        BookContext context = new BookContext();
        // GET: Authorization
        public ActionResult Index()
        {
            Authorizates authorization = new Authorizates();
            return View(authorization);
        }
        [HttpPost]
        public ActionResult Index(Authorizates authorization)
        {
            if (ModelState.IsValid)
            {
                context.Authorizates.Add(authorization);
                context.SaveChanges();
                Redirect("Home");
            }
            return View();
        }
        // GET: Authorization/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Authorization/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Authorization/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Authorization/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Authorization/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Authorization/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Authorization/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
