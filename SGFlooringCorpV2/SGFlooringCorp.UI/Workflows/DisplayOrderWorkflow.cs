using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.BLL;
using SGFlooringCorp.UI.Workflows;
using SGFlooringCorp.Data;
using SGFlooringCorp.Models;
using SGFlooringCorp.UI.Utilities;


namespace SGFlooringCorp.UI.Workflows
{
    class DisplayOrderWorkflow
    {
        private Response<List<Order>> _currentOrder = new Response<List<Order>>();

        public void Execute()
        {
            Screens.ShowRequestDateForOrder();
            DateTime date = UserInteractions.GetDateFromUser();

            DisplayAllOrdersForTheDay(date);
        }

       

        public void DisplayAllOrdersForTheDay(DateTime orderDate)
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var response = ops.ListAll(orderDate);
            _currentOrder = response;


            Console.Clear();
            if (response.Success)
            {
                Screens.ShowListOfOrders(_currentOrder, orderDate);
                UserInteractions.PressKeyToContinue();
            }
            else
            {
               Screens.ShowDisplayOrdersFailed(_currentOrder, orderDate);
                UserInteractions.PressKeyToContinue();
            }
        }

       
       
    }
}
