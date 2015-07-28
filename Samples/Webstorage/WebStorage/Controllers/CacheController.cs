using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using WebStorage.Models;

namespace WebStorage.Controllers
{
    public class CacheController : Controller
    {

        public ActionResult ReadCache()
        {
            List<Contact> contacts = new List<Contact>();

            if (HttpRuntime.Cache["ContactList"] == null)
            {
                contacts = new List<Contact>()
                {
                    new Contact() {Email = "jo@sm.com", Name = "Joe"},
                    new Contact() {Email = "alice@sm.com", Name = "Alice"}
                };

                HttpRuntime.Cache.Insert("ContactList", contacts, null, DateTime.Now.AddHours(8),
                    Cache.NoSlidingExpiration);
            }
            else
            {
                contacts = (List<Contact>) HttpRuntime.Cache["ContactList"];

            }
            

            return View(contacts);
        }

    }
}
