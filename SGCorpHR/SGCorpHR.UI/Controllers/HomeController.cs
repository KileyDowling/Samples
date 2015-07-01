using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SGCorpHR.BLL;
using SGCorpHR.Models;
using System.IO;
using System.Net;

namespace SGCorpHR.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var ops = new FileOperations();
            var response = ops.DisplayFiles();
            return View(response);
        }

        public ActionResult Save(HttpPostedFileBase file)
        {
            if (file.ContentLength >0)
            {
                var fullPath = Server.MapPath(@"~/Resumes");
            file.SaveAs(String.Format(@"{0}\{1}", fullPath, file.FileName));
            }
            

            return View("Index");

        }
    }
}