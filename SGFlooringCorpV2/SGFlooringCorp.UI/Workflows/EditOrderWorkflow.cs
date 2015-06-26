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
            //get orderDate from user
            //get orderNumber from user
            //display only that order to user using PrintOrderDetails
            OrderRequest newOrderRequest = new OrderRequest();
            OrderOperations ops = OperationsFactory.CreateOrderOperations();

            DateTime orderDate = UserInteractions.GetDateFromUser();

            //set up new order
            newOrderRequest.OrderDate = orderDate;
            newOrderRequest.Order = new Order();

            Console.WriteLine("Please enter your order number");
            var orderNumber = Console.ReadLine();
            newOrderRequest.Order.OrderNumber = int.Parse(orderNumber);

            //set up old order
            OrderRequest oldOrderRequest = new OrderRequest();
            oldOrderRequest.OrderDate = orderDate;
            oldOrderRequest.Order = new Order();
            oldOrderRequest.Order.OrderNumber = int.Parse(orderNumber);
            Response<Order> oldOrderResponse = ops.GetSelectedOrder(oldOrderRequest);
            oldOrderRequest.Order = oldOrderResponse.Data;


            PrintOrderDetails(oldOrderResponse);

            //edit order details
            newOrderRequest = MakeEdits(oldOrderRequest);
            Response<Order> editedOrdeResponse = ops.EditSelectedOrder(newOrderRequest, oldOrderRequest);

            //save response to file
            UserInteractions.PressKeyToContinue();
            PrintOrderDetails(editedOrdeResponse);
            UserInteractions.PressKeyToContinue();

        }

        public OrderRequest MakeEdits(OrderRequest oldOrderRequest)
        {
            Console.WriteLine("Please input a new customer name ({0})", oldOrderRequest.Order.CustomerName);
            oldOrderRequest.Order.CustomerName = Console.ReadLine();

            Console.WriteLine("Please input the state abbreviation ({0})", oldOrderRequest.Order.StateAbbreviation);
            oldOrderRequest.Order.StateAbbreviation = Console.ReadLine();

            Console.WriteLine("Please input the product type ({0})", oldOrderRequest.Order.ProductType);
            oldOrderRequest.Order.ProductType = Console.ReadLine();

            Console.WriteLine("Please input the area ({0})", oldOrderRequest.Order.Area);
            oldOrderRequest.Order.Area = decimal.Parse(Console.ReadLine());

            return oldOrderRequest;
        }


        private void PrintOrderDetails(Response<Order> response)
        {
            Console.WriteLine("Order #{0}: ", response.Data.OrderNumber);
            Console.WriteLine("Customer Name: {0}, ", response.Data.CustomerName);
            Console.WriteLine("Product Type: {0}, ", response.Data.ProductType);
            Console.WriteLine("State: {0}, ", response.Data.StateAbbreviation);
            Console.WriteLine("Tax Rate: {0:C}, ", response.Data.TaxRate);
            Console.WriteLine("Area: {0}, ", response.Data.Area);
            Console.WriteLine("Labor Cost: {0:C}, ", response.Data.TotalLaborCost);
            Console.WriteLine("Material Cost: {0:C}, ", response.Data.MaterialCost);
            Console.WriteLine("Total Tax: {0:C}, ", response.Data.TotalTax);
            Console.WriteLine("\tTotal: {0:C} \n\n", response.Data.Total);

        }
    }
}
