using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyContacts.UI.Models;

namespace MyContacts.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var database = new FakeContactsDatabase();

            var contacts = database.GetAll();

            return View(contacts);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact()
        {
            var c = new Contact();
            c.Name = Request.Form["Name"];
            c.PhoneNumber = Request.Form["PhoneNumber"];

            var database = new FakeContactsDatabase();
            database.Add(c);

            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            int contactId = int.Parse(RouteData.Values["id"].ToString());

            var database = new FakeContactsDatabase();
            var contact = database.GetById(contactId);

            return View(contact);

        }

        [HttpPost]
        public ActionResult EditContact()
        {
            var c = new Contact();
            c.Name = Request.Form["Name"];
            c.PhoneNumber = Request.Form["PhoneNumber"];
            c.ContactID = int.Parse(Request.Form["ContactID"]);

            var database = new FakeContactsDatabase();

            database.Edit(c);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteContact()
        {
            int contactID = int.Parse(Request.Form["ContactID"]);

            var database = new FakeContactsDatabase();

            database.Delete(contactID);

            var contacts = database.GetAll();

            return View("Index",contacts);
        }
    }
}