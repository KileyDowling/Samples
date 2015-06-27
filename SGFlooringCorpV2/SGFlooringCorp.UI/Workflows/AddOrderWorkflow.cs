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
    internal class AddOrderWorkflow
    {
        public void Execute()
        {
            var request = new OrderRequest();
            Screens.ShowAddOrder();
            request = GenerateOrderInformation(request);
           var response = SaveOrderInformation(request);
            Screens.ShowAddOrderConfirmation(response.Data);


            UserInteractions.PressKeyToContinue();

        }

        public Response<Order> SaveOrderInformation(OrderRequest request)
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var response = ops.CreateOrder(request);
            return response;

        }

        public OrderRequest GenerateOrderInformation(OrderRequest request)
        {
            request.OrderDate = DateTime.Today;
            Console.WriteLine("Order Date: {0}", request.OrderDate.ToString("D"));
            request.Order = new Order();

            //user requested
            Console.WriteLine("Please enter your name");
            request.Order.CustomerName = Console.ReadLine();
            Console.WriteLine("Please enter your state");
            request.Order.StateAbbreviation = Console.ReadLine();
            Console.WriteLine("Please enter your product type");
            request.Order.ProductType = Console.ReadLine();
            Console.WriteLine("Please enter the area");
            request.Order.Area = decimal.Parse(Console.ReadLine());

            return request;
        }


     

       
    }

}
