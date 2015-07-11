using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGCorpHR.DATA;
using SGCorpHR.Models;

namespace SGCorpHR.BLL
{
    public class PolicyDocumentsOperations
    {
        public Response<List<string>> GetAllCategories(string folderPath)
        {
            var repo = new PolicyDocumentRepository();
            Response<List<string>> response = new Response<List<string>>();
            List<string> allCategories = repo.GetAllPolicyDocCategories(folderPath);

            response.Data = allCategories;
            response.Success = true; 

            return response;
        }

        public Response<List<PolicyDocument>> GetAllPolicyDocuments(string filePath)
        {
            var repo = new PolicyDocumentRepository();
            Response<List<PolicyDocument>> response = new Response<List<PolicyDocument>>();
            List<PolicyDocument> policyDocs = repo.GetAllPolicyDocuments(filePath);
            try
            {
                if (policyDocs != null)
                {
                    if (policyDocs.Count > 0)
                    {
                        response.Success = true;
                        response.Data = policyDocs;
                    }
                    else
                    {
                        response.Success = false;
                        response.Message = "There are no files to display.";
                    }
                }
                else
                {
                    response.Success = false;
                    response.Message = "That category does not currently exist";
                }

            }
            catch (Exception  ex)
            {

                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public void AddPolicyDocument(PolicyDocument policyDocument, string folderPath)
        {
            var repo = new PolicyDocumentRepository();
           repo.AddNewPolicyDocument(policyDocument, folderPath);
        }
    }
}
