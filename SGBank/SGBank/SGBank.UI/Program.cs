﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.UI.Workflows;

namespace SGBank.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = new MainMenu();
            mainMenu.Execute();
        }
    }
}
