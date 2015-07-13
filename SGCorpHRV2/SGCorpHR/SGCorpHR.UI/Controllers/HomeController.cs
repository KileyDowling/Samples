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
using SGCorpHR.UI.Models;


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
            return RedirectToAction("ViewResume");

        }
       
        public ActionResult Save()
        {
            return View("Save");
        }

        public ActionResult ViewResume()
        {
            var ops = new FileOperations();
            var filePath = Server.MapPath(@"~/Resumes"); ;
            var response = ops.DisplayFiles(filePath);
            return View(response);
        }

        public ActionResult ViewSuggestions()
        {
            var filePath = Server.MapPath(@"~/Suggestions/Suggestions.txt"); ;
            var ops = new SuggestionOperations();
            var response = ops.DisplaySuggestions(filePath);
            return View(response);
        }

        public ActionResult DeleteSuggestion(int suggestionID)
        {
            var filePath = Server.MapPath(@"~/Suggestions/Suggestions.txt"); ;
            var ops = new SuggestionOperations();
            ops.DeleteSuggestions(suggestionID, filePath);
            return RedirectToAction("ViewSuggestions");

        }

        public ActionResult DownloadResume(string filePath)
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@filePath);
            string fileName = filePath.Substring(filePath.Length-8, 8);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public ActionResult DeleteResume(string filePath)
        {
           System.IO.File.Delete(@filePath);
           return RedirectToAction("ViewResume");
        }
   
        public ActionResult AddSuggestion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSuggestionForm(Suggestion suggestion)
        {
            var filePath = Server.MapPath(@"~/Suggestions/Suggestions.txt"); 
            var ops = new SuggestionOperations();
            ops.AddSuggestion(suggestion, filePath);

            return View("ConfirmationPage");
        }

        public ActionResult SelectPolicyDocCategory()
        {
            return View("SelectPolicyDocCategory");
        }

        [HttpPost]
        public ActionResult SelectPolicyDocCategory(string categoryName)
        {
           return RedirectToAction("ViewPolicyDocuments", new { category = categoryName });
        }
    
        public ActionResult ViewPolicyDocuments(string category)
        {
            var filePathToMap = string.Format(@"~/PolicyDocuments/{0}", category);
            var filePath = Server.MapPath(@filePathToMap);
            var ops = new PolicyDocumentsOperations();
            var vm = new CategoryVM()
            {
                Category =
                {
                    CategoryName = category
                },
                Response = ops.GetAllPolicyDocuments(filePath)
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult SavePolicyDocument(HttpPostedFileBase file, PolicyDocument policyDocument)
        {
            if (file.ContentLength > 0)
            {
                var fullPath = Server.MapPath(@"~/PolicyDocuments");
                var filePathComplete = String.Format(@"{0}\{1}\{2}", fullPath, policyDocument.Category.CategoryName, file.FileName);
                policyDocument.FilePath = filePathComplete;

                var ops = new PolicyDocumentsOperations();

                var folderPath = fullPath + @"\" + policyDocument.Category.CategoryName;
                ops.AddPolicyDocument(policyDocument, folderPath);                
                //file.SaveAs(filePathComplete);

            }

            return RedirectToAction("ViewPolicyDocuments", new { category = policyDocument.Category.CategoryName});
        }

        public ActionResult UploadPolicyDoc()
        {
            var ops = new PolicyDocumentsOperations();
            var model = new CategoryVM();
            //model.CreateCategoryList(ops.GetAllCategories());
            return View("UploadPolicyDoc");
        }

        public ActionResult DownloadPolicyDoc(string filePath)
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@filePath);
            string fileName = filePath.Substring(filePath.Length - 8, 8);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public ActionResult DeletePolicyDoc(string filePath, CategoryVM model)
        {
            System.IO.File.Delete(@filePath);
            return RedirectToAction("ViewPolicyDocuments", new { category = model.Category});
        }
    }
}