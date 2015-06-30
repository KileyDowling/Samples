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
    class EditOrderWorkflow
    {
        public void Execute()
        {
            OrderRequest oldOrderRequest = new OrderRequest();
            OrderRequest newOrderRequest = new OrderRequest();
            oldOrderRequest = SetUpOrderRequest(oldOrderRequest);

            newOrderRequest = MakeEdits(oldOrderRequest);
            ConfirmEdits(oldOrderRequest, newOrderRequest);
            UserInteractions.PressKeyToContinue();

        }

        public OrderRequest SetUpOrderRequest(OrderRequest orderRequest)
        {
            var orderDate = UserInteractions.PromptForValidOrderDate(orderRequest);

            orderRequest.OrderDate = orderDate.OrderDate;
            orderRequest.Order = new Order();
            orderRequest = UserInteractions.PromptForValidOrderNumber(orderRequest);

            return orderRequest;
        }

        public OrderRequest MakeEdits(OrderRequest oldOrderRequest)
        {
            Console.WriteLine("Please input a new customer name ({0}), or press enter to continue without changing it", oldOrderRequest.Order.CustomerName);
            var input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
                oldOrderRequest.Order.CustomerName = input;

            Console.WriteLine("Would you like to change your current state ({0})? If not, press enter to continue. ", oldOrderRequest.Order.StateAbbreviation);
            input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
                oldOrderRequest.Order.StateAbbreviation = UserInteractions.PromptForValidState("Please input a valid choice");


            Console.WriteLine("Would you like to change your current state ({0})? If not, press enter to continue. ", oldOrderRequest.Order.ProductType);
            input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
                oldOrderRequest.Order.ProductType = UserInteractions.PromptForValidProductType("Please input the product type");

            Console.WriteLine("Would you like to change the current area ({0})? If not, press enter to continue. ", oldOrderRequest.Order.Area);
             input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
                oldOrderRequest.Order.Area = UserInteractions.PromptForDecimal("Please enter the area");
   
            return oldOrderRequest;
        }

        public void ConfirmEdits(OrderRequest oldOrderRequest, OrderRequest newOrderRequest)
        {
            var ops = OperationsFactory.CreateOrderOperations();
            newOrderRequest = ops.GetTaxRate(newOrderRequest);
            newOrderRequest = ops.UpdateCosts(newOrderRequest);
            Screens.ShowEditOrderConfirmation(newOrderRequest.Order);
            var confirm = UserInteractions.PromptForConfirmation("Save requested changes to order? (Y)es or (N)o.");
            var response = new Response<Order>();
            if (confirm == "Y")
            {
                response = ops.EditSelectedOrder(oldOrderRequest, newOrderRequest);
                Screens.ShowEditOrderConfirmation(response.Data);
            }
            else
            {
                Console.WriteLine("Changes not saved");
            }
        }


    }
}
