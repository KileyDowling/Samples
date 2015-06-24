using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.BLL;
using SGFlooringCorp.Models;

namespace SGFlooringCorp.UI.Workflows
{
    class AddOrderWorkflow
    {
        public void Execute()
        {
            string DateToday = DateTime.Now.ToString("MMddyyyy");

            //first, check to see if there is already a file for that day
            //if so, just write to that file - handle this in BLL

            var ops = new OrderOperations();
            ops.CreateFile(DateToday);

            //needs to create a new UserInteraction and call a method to get the OrderInformation
        }
    }
}
