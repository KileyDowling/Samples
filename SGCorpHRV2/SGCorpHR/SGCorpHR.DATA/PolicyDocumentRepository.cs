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


            List<PolicyDocument> policyDocuments = new List<PolicyDocument>();

            var reader = File.ReadAllLines(filePath);

            for (int i = 1; i < reader.Length; i++)
            {
                var columns = reader[i].Split(',');

                var policyDoc = new PolicyDocument();

                policyDoc.Name = columns[0];
                policyDoc.Category = columns[1];
                policyDoc.FilePath = columns[2];

                policyDocuments.Add(policyDoc);
            }

            return policyDocuments;
        }
    }
}
