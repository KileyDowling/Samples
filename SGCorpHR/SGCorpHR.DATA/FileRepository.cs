using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SGCorpHR.Models;

namespace SGCorpHR.DATA
{
   public class FileRepository
   {
       public List<Resumes> GetFiles()
       {
           var resume = new Resumes();
           var directory = new DirectoryInfo(@"C:\Users\Apprentice\Desktop\GitHub\KileyDowling\SGCorpHR\SGCorpHR.UI\Resumes");
           var files = directory.GetFiles();
           if (files.Any())
           {
               var resumes = new List<Resumes>();
               foreach (var file in files)
               {
                   resume.FilePath = file.FullName;
                   resume.FileName = file.Name;
                   resumes.Add(resume);
               }

               return resumes;
           }
           return null;

       }
   }
}
