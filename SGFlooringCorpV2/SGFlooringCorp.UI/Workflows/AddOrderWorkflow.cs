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
            request = GenerateOrderInformation(request);
            request = GetTaxRate(request);
            request = UpdateCosts(request);
            SaveOrderInformation(request);
            PrintOrderDetails(request);


            UserInteractions.PressKeyToContinue();

        }

        public void SaveOrderInformation(OrderRequest request)
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var response = ops.CreateOrder(request);

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

        public OrderRequest GetTaxRate(OrderRequest orderRequest)
        {
            var ops = OperationsFactory.CreateTaxOperations();
            orderRequest.Order.TaxRate = ops.GetRate(orderRequest.Order.StateAbbreviation);

            return orderRequest;

        }

        public OrderRequest UpdateCosts(OrderRequest orderRequest)
        {
            var ops = OperationsFactory.CreateProductOperations();
            orderRequest.Order.LaborCostPerSquareFoot = ops.GetLaborCostPerSquareFoot(orderRequest.Order.ProductType);
            orderRequest.Order.CostPerSquareFoot = ops.GetCostPerSquareFoot(orderRequest.Order.ProductType);
            orderRequest.Order.MaterialCost = ops.CalculateMaterialCost(orderRequest);
            orderRequest.Order.TotalLaborCost = ops.CalculateLaborCost(orderRequest);
            orderRequest.Order.TotalTax = ops.CalculateTax(orderRequest);
            orderRequest.Order.Total = ops.CalculateTotal(orderRequest);



            return orderRequest;

        }

        private void PrintOrderDetails(OrderRequest orderRequest)
        {
            Console.Clear();
            Console.WriteLine("********** ORDER SUMMARY **********");
            Console.WriteLine("Order #{0}: ", orderRequest.Order.OrderNumber);
            Console.WriteLine("\tCustomer Name: {0}", orderRequest.Order.CustomerName);
            Console.WriteLine("\tProduct Type: {0}", orderRequest.Order.ProductType);
            Console.WriteLine("\tState: {0}", orderRequest.Order.StateAbbreviation);
            Console.WriteLine("\tTax Rate: {0:C}", orderRequest.Order.TaxRate);
            Console.WriteLine("\tArea: {0}", orderRequest.Order.Area);
            Console.WriteLine("\tLabor Cost: {0:C}", orderRequest.Order.TotalLaborCost);
            Console.WriteLine("\tMaterial Cost: {0:C}", orderRequest.Order.MaterialCost);
            Console.WriteLine("\tTotal Tax: {0:C}", orderRequest.Order.TotalTax);
            Console.WriteLine("\t\tTotal: {0:C} \n\n", orderRequest.Order.Total);

        }

       
    }

}
