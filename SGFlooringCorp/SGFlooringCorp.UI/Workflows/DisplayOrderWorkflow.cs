using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private List<Order> _currentOrder = new List<Order>();

        //Note that the Date has to be looked up, and then the OrderNumber
        public void Execute()
        {
            string date = GetDateFromUser();

            DisplayAllOrdersForTheDay(date);
        }

        public string GetDateFromUser()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the date of the order you wish to look up ");
                Console.Write("in this format(MMDDYYYY): ");
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

        public void DisplayAllOrdersForTheDay(string date)
        {
            var ops = new OrderOperations();
            var response = ops.GetAllOrders(date);

            Console.Clear();
            if (response.Success)
            {
                _currentOrder = response.Data;
                PrintOrderDetails(response);
                UserInteractions.PressKeyToContinue();
            }
            else
            {
                Console.WriteLine(response.Message);
                UserInteractions.PressKeyToContinue();
            }
        }

        //public void DisplayOrderInformation(string Date)
        //{
        //    var ops = new OrderOperations();
        //    var response = ops.GetOrder(Date);
        //    Console.Clear();

        //    if (response.Success)
        //    {
        //        _currentOrder = response.Data;
        //        PrintOrderDetails(response);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Order Not Found");
        //    }
        //    UserInteractions.PressKeyToContinue();

        //}

        
        private void PrintOrderDetails(Response<List<Order>> response)
        {
            foreach (var item in response.Data)
            {
                Console.Write("Order #{0}: ", item.OrderNumber);
                Console.Write("{0}, ", item.CustomerName);
                Console.Write("{0}, ", item.ProductType);
                Console.Write("{0}, ", item.State);
                Console.Write("{0}, ", item.TaxRate);
                Console.Write("{0}, ", item.Area);
                Console.Write("{0} \n\n", item.Total);
                
            }
        }
        

        //private string GetOrderNumberFromUser(string Date)
        //{
        //    do
        //    {
        //        Console.Clear();
        //        Console.Write("Enter the Order Number: ");
        //        string input = Console.ReadLine();
        //        int thisOrderNumber;

        //        if (int.TryParse(input, out thisOrderNumber))
        //        {
        //            return input;
        //        }   

        //        Console.WriteLine("That was not a valid Order Number.  Press any key to continue...");
        //        Console.ReadKey();
        //    } while (true);
        //}
    }
}
