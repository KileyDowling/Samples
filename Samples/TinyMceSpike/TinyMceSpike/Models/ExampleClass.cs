﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;

namespace TinyMceSpike.Models
{
    public class ExampleClass
    {
        // This attributes allows your HTML Content to be sent up
        [AllowHtml]
        public string HtmlContent { get; set; }

    
    }
}