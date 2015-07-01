using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGCorpHR.DATA;
using SGCorpHR.Models;

namespace SGCorpHR.BLL
{
    class SuggestionOperations
    {
        public Response<List<Suggestion>> DisplaySuggestions()
        {
            var repo = new SuggestionRepository();
            var response = new Response<List<Suggestion>>();
            var suggestions = repo.GetAllSuggestions();
            try
            {
                if (suggestions.Count > 0)
                {
                    response.Success = true;
                    response.Data = suggestions;

                }
                else
                {
                    response.Success = false;
                    response.Message = "No Files were found";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
