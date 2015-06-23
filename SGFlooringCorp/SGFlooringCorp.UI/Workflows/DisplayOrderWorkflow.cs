using System;
using System.Collections.Generic;
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
       Order _currentOrder = new Order();

        //Note that the Date has to be looked up, and then the OrderNumber
        public void Execute()
        {
            string Date = GetDateFromUser();

            string OrderNumber = GetOrderNumberFromUser(Date);

            DisplayOrderInformation(Date, OrderNumber);
        }

        private string GetDateFromUser()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the date of the order you wish to look up ");
                Console.Write("in this format(MMDDYYYYY): ");
                string input = Console.ReadLine();
                int thisDate;

                if (int.TryParse(input, out thisDate))
                {
                    return input;
                }

                Console.WriteLine("That was not a valid date.  Press any key to continue...");
                Console.ReadKey();
            } while (true);
        }

        public void DisplayOrderInformation(string Date, string OrderNumber)
        {
            var ops = new OrderOperations();
            var response = ops.GetOrder(Date, OrderNumber);
            Console.Clear();

            if (response.Success)
            {
                _currentOrder = response.Data;
                PrintOrderDetails(response);
            }
            else
            {
                Console.WriteLine("Order Not Found");
            }
            UserInteractions.PressKeyToContinue();

        }

        
        private void PrintOrderDetails(Response<Order> response)
        {
            Console.WriteLine("Date: {0}", response.Data.OrderDate);
            Console.WriteLine("Order Number: {0}", response.Data.OrderNumber);
            Console.WriteLine("Customer: {0}", response.Data.CustomerName);
            Console.WriteLine("Product Type: {0}", response.Data.ProductType);
            Console.WriteLine("Total Labor Cost: {0}", response.Data.TotalLaborCost);
            Console.WriteLine("Material Cost: {0}", response.Data.MaterialCost);
            Console.WriteLine("Tax: {0}", response.Data.TotalTax);
            Console.WriteLine("Total Cost: {0}", response.Data.Total);


        }
        

        private string GetOrderNumberFromUser(string Date)
        {
            do
            {
                Console.Clear();
                Console.Write("Enter the Order Number: ");
                string input = Console.ReadLine();
                int thisOrderNumber;

                if (int.TryParse(input, out thisOrderNumber))
                {
                    return input;
                }
                    

                Console.WriteLine("That was not a valid Order Number.  Press any key to continue...");
                Console.ReadKey();
            } while (true);
        }
    }
}
