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

        public List<PolicyDocument> GetAllPolicyDocuments(string filePath)
        {
            var directory = new DirectoryInfo(filePath);
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
            return null;
        }
    }
}