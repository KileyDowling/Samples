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

        public ActionResult Save(FormCollection formCollection)
        {
            if (Request != null)
            {
                HttpPostedFileBase file = Request.Files["UploadedFile"];

                if((file != null) && (file.ContentLength > 0) && !String.IsNullOrEmpty(file.FileName))
                {
                    string fileName = file.FileName;
                    string fileContentType = file.ContentType;
                    byte[] fileBytes = new byte[file.ContentLength];
                    file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));

                }
            }

            return View("Index");

        }
    }
}