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
        private Order _currentOrder = new Order();

        public void Execute()
        {
            //get orderDate from user
            //get orderNumber from user
            //display only that order to user using PrintOrderDetails
            OrderRequest newOrderRequest = new OrderRequest();
            OrderOperations ops = OperationsFactory.EditOrderOperations();

            DateTime orderDate = UserInteractions.GetDateFromUser();

            //set up new order
            newOrderRequest.OrderDate = orderDate;
            newOrderRequest.Order = new Order();
            
            Console.WriteLine("Please enter your order number");
            var orderNumber =Console.ReadLine();
            newOrderRequest.Order.OrderNumber = orderNumber;

            //set up old order
            OrderRequest oldOrderRequest = new OrderRequest();
            oldOrderRequest.OrderDate = orderDate;
            oldOrderRequest.Order = new Order();
            oldOrderRequest.Order.OrderNumber = orderNumber;
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
            Console.WriteLine("Please input a new customer name {0}", oldOrderRequest.Order.CustomerName);
            oldOrderRequest.Order.CustomerName = Console.ReadLine();

            return oldOrderRequest;
        }


        private void PrintOrderDetails(Response<Order> response)
        {
                Console.Write("Order #{0}: ", response.Data.OrderNumber);
                Console.Write("{0}, ", response.Data.CustomerName);
                Console.Write("{0}, ", response.Data.ProductType);
                Console.Write("{0}, ", response.Data.StateAbbreviation);
                Console.Write("{0}, ", response.Data.TaxRate);
                Console.Write("{0}, ", response.Data.Area);
                Console.Write("{0} \n\n", response.Data.Total);

            }
        }
    }
