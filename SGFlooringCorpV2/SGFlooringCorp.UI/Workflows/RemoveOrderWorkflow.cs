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
            ConfirmRemoval(request);
            UserInteractions.PressKeyToContinue();

        }

        public OrderRequest OrderToRemoveInformation()
        {
            var request = new OrderRequest();
            request = UserInteractions.PromptForValidOrderDate(request);
            request.Order = new Order();
            request = UserInteractions.PromptForValidOrderNumber(request);

            return request;
        }


        public void ConfirmRemoval(OrderRequest request)
        {
            var ops = OperationsFactory.CreateOrderOperations();
            Screens.ShowConfirmRemoveOrder(request.Order);
            var confirm = UserInteractions.PromptForConfirmation("Remove Order? (Y)es or (N)o.");
            var response = new Response<Order>();
            if (confirm == "Y")
            {
                response = RemoveOrder(request);
                Screens.ShowRemoveOrderConfirmation(response.Data);
            }
            else
            {
                Console.WriteLine("Order not deleted");
            }
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
