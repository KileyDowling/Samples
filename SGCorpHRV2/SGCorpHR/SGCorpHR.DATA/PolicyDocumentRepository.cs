using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGCorpHR.Models;

namespace SGCorpHR.DATA
{
    public class PolicyDocumentRepository
    {

        public List<PolicyDocument> GetAllPolicyDocuments(string folderPath)
        {
            var directory = new DirectoryInfo(folderPath);
            if (directory.Exists)
            {
                var files = directory.GetFiles();
                if (files.Any())
                {
                    List<PolicyDocument> policyDocuments = new List<PolicyDocument>();
                    foreach (var file in files)
                    {
                        PolicyDocument policyDoc = new PolicyDocument();
                        policyDoc.FilePath = file.FullName;
                        policyDoc.Name = file.Name;
                        policyDocuments.Add(policyDoc);
                    }


                    return policyDocuments;

                }
            }
            return null;

        }
        

        public void AddNewPolicyDocument(PolicyDocument policyDoc, string folderPath)
        {

            if (Directory.Exists(folderPath))
            {
                File.Create(policyDoc.FilePath);
            }
            else
            {
                var newFolder = string.Format(@"{0}\{1}", folderPath, policyDoc.Category.CategoryName);
                Directory.CreateDirectory(newFolder);
                var directory = new DirectoryInfo(newFolder);
                File.Create(policyDoc.FilePath);
                

            }
        }
    }
}