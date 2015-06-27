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
            var request = new OrderRequest();
            Screens.ShowRemoveAnOrder();
            request = OrderToRemoveInformation();
            var response = RemoveOrder(request);
            Screens.ShowConfirmRemoveOrder(response.Data);
            UserInteractions.PressKeyToContinue();
            Screens.ShowRemoveOrderConfirmation(response.Data);
            UserInteractions.PressKeyToContinue();

        }

        public OrderRequest OrderToRemoveInformation()
        {
            var request = new OrderRequest();
            Console.WriteLine("Please enter an order date");
            DateTime orderDate = UserInteractions.GetDateFromUser();
            request.OrderDate = orderDate;
            request.Order = new Order();
            Console.WriteLine("Please enter an order number");
            request.Order.OrderNumber = int.Parse(Console.ReadLine());

            return request;
        }

        public Response<Order> RemoveOrder(OrderRequest request)
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var response = ops.DeleteOrder(request);

            Console.Clear();

            return response;
        }
    }
}
