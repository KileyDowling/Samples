using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGCorpHR.Models;

namespace SGCorpHR.UI.Models
{
    public class CategoryVM
    {
        public string CategoryName { get; set; }
        public Response<List<PolicyDocument>> Response { get; set; } 
    }
}