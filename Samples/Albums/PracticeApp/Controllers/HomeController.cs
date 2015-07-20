using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeApp.Models;

namespace PracticeApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var database = new FakeAlbumDatabase();
            var albums = database.GetAll();

            return View(albums);
        }


        public ActionResult Add()
        {
            return View();
        }
    }
}