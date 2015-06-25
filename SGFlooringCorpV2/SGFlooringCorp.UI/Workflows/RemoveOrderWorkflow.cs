using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.BLL;
using SGFlooringCorp.Models;
using SGFlooringCorp.UI.Utilities;

namespace SGFlooringCorp.UI.Workflows
{
    internal class RemoveOrderWorkflow
    {
        public void Execute()
        {
            var orderRequest = UserInteractions.PromptForValidOrder();


        }

        public void RemoveOrder(OrderRequest request)
        {
            var ops = new OrderOperations();
            var response = ops.DeleteOrder(request);

            Console.Clear();
            if (response.Success)
            {
                Console.WriteLine(response.Message);
                UserInteractions.PressKeyToContinue();
            }
            else
            {
                Console.WriteLine(response.Message);
                UserInteractions.PressKeyToContinue();
            }
        }
    }
}
