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
            OrderOperations ops = OperationsFactory.CreateOrderOperations();

            OrderRequest oldOrderRequest = new OrderRequest();
            OrderRequest newOrderRequest = new OrderRequest();
            oldOrderRequest = SetUpOrderRequest(oldOrderRequest);

            newOrderRequest = MakeEdits(oldOrderRequest);
            Response<Order> editedOrdeResponse = ops.EditSelectedOrder(oldOrderRequest,newOrderRequest);

            UserInteractions.PressKeyToContinue();
            Screens.ShowEditOrderConfirmation(editedOrdeResponse.Data);
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
            Console.WriteLine("Please input a new customer name ({0})", oldOrderRequest.Order.CustomerName);
            var input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
                oldOrderRequest.Order.CustomerName = input;

            Console.WriteLine("To change your current state ({0}) type 'no'. Otherwise, press enter to continue. ", oldOrderRequest.Order.StateAbbreviation);
            input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
            {
                input = UserInteractions.PromptForValidState("Please input a valid choice");
                oldOrderRequest.Order.StateAbbreviation = input;
            }

            Console.WriteLine("Please input the product type ({0})", oldOrderRequest.Order.ProductType);
            input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
                oldOrderRequest.Order.ProductType= input;

            Console.WriteLine("Please input the area ({0})", oldOrderRequest.Order.Area);
             input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
                oldOrderRequest.Order.Area = decimal.Parse(input);

            return oldOrderRequest;
        }


    }
}
