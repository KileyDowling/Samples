using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SGCorpHR.BLL;
using SGCorpHR.Models;
using System.IO;
using System.Net;
using SGCorpHR.DATA;


namespace SGCorpHR.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult SaveFile(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                var fullPath = Server.MapPath(@"~/Resumes");
                file.SaveAs(String.Format(@"{0}\{1}", fullPath, file.FileName));
            }


            return RedirectToAction("Index");

        }
       
        public ActionResult Save()
        {
           


            return View("Save");

        }

        public ActionResult ViewResume()
        {

            var ops = new FileOperations();
            var response = ops.DisplayFiles();
            return View(response);

        }

        public ActionResult ViewSuggestions()
        {
            var ops = new SuggestionOperations();
            var response = ops.DisplaySuggestions();
            return View(response);
        }

        public ActionResult DeleteSuggestion(int suggestionID)
        {
            var ops = new SuggestionOperations();
            ops.DeleteSuggestions(suggestionID);
            return RedirectToAction("ViewSuggestions");

        }

        
        public ActionResult AddSuggestion()
        {
            return View("AddSuggestion");
        }
        [HttpPost]
        public ActionResult AddSuggestionForm(Suggestion suggestion)
        {
            var ops = new SuggestionOperations();
            ops.AddSuggestion(suggestion);
            return RedirectToAction("AddSuggestion");
        }
    }
}