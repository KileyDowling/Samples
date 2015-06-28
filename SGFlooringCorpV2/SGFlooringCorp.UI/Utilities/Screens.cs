using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Models;
using SGFlooringCorp.UI.Workflows;

namespace SGFlooringCorp.UI.Utilities
{
    public class Screens
    {
        public  static void MainMenu()
        {
                Console.Clear();
                Console.WriteLine("**************** SG Corp Flooring Program ****************");
                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.Write("*");
                Console.WriteLine("  1. Display Orders");
                Console.Write("*");
                Console.WriteLine("  2. Add an Order");
                Console.Write("*");
                Console.WriteLine("  3. Edit an Order");
                Console.Write("*");
                Console.WriteLine("  4. Remove an Order");
                Console.Write("*");
                Console.WriteLine("  5. Quit");
                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.WriteLine("**********************************************************");
               
            }

        public static void ShowRequestDateForOrder()
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                           Display Orders ");
            Console.WriteLine("********************************************************************************");
        }

        public static void ShowListOfOrders(Response<List<Order>> response, DateTime orderDate)
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                           Orders for {0:d} ", orderDate);
            Console.WriteLine("********************************************************************************");
            foreach (var order in response.Data)
            {
                Console.WriteLine("");
                Console.WriteLine(FormatedOrder(order));
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------------");

            }
        }

        public static void ShowDisplayOrdersFailed(Response<List<Order>> response, DateTime orderDate)
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                  Display orders failed for {0:d} ", orderDate);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("There was a problem with your request: {0}.", response.Message);
            Console.WriteLine("");
        }

        public static void ShowAddOrder()
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                           Add Order ");
            Console.WriteLine("********************************************************************************");
        }

        public static void ShowAddOrderConfirmation(Order order)
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                    Order Added Successfully ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("You successfully added the order.");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine(FormatedOrder(order));
            Console.WriteLine("");
        }

        public static void ShowAddOrderFailed(Response<Order> response)
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                    Adding Order Failed ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("The order was not added: {0}.", response.Message);
            Console.WriteLine("");
        }

        public static void ShowEditOrderConfirmation(Order order)
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                    Order Edited Successfully ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("You successfully edited the order.");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine(FormatedOrder(order));
            Console.WriteLine("");
        }

        public static void ShowEditOrderFailed(Response<Order> response)
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                    Editing Order Failed ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("The order was not edited: {0}.", response.Message);
            Console.WriteLine("");
        }

        public static void ShowConfirmAddOrder(Order order)
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                      Confirm Add Order ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine(FormatedOrder(order));
            Console.WriteLine("");
        }

        public static void ShowConfirmRemoveOrder(Order order)
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                      Confirm Remove Order ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine(FormatedOrder(order));
            Console.WriteLine("");
        }

        public static void ShowRemoveAnOrder()
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                           Remove An Order ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
        }

        public static void ShowRemoveOrderConfirmation(Order order)
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                    Order Removed Successfully ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("You successfully removed the following order.");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine(FormatedOrder(order));
            Console.WriteLine("");
        }

        public static void ShowRemoveOrderFailed(Response<Order> response)
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                    Removing Order Failed ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("The order was not edited: {0}.", response.Message);
            Console.WriteLine("");
        }

        public static string FormatedOrder(Order order)
        {
            return string.Format("Order Number:                   {0}" +
                                  "\nCustomer Name:                  {1}" +
                                  "\nProduct Type:                   {2}" +
                                  "\nState Abbreviation:             {3}" +
                                  "\nArea:                           {11}" +
                                  "\nCost Per Square Foot:           {4:C}" +
                                  "\nLabor Cost Per Square Foot:     {5:C}" +
                                  "\nMaterial Cost:                  {6:C}" +
                                  "\nLabor Cost:                     {7:C}" +
                                  "\nTax Rate:                       {8:P}" +
                                  "\nTax:                            {9:C}" +
                                  "\nTotal:                          {10:C}",
                                  order.OrderNumber, order.CustomerName, order.ProductType, order.StateAbbreviation, order.CostPerSquareFoot,
                                  order.LaborCostPerSquareFoot, order.MaterialCost, order.TotalLaborCost, order.TaxRate /100, order.TotalTax, order.Total, order.Area);
        }
    }

     
    }

