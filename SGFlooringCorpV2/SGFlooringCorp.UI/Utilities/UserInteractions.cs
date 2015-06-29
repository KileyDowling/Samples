using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.BLL;
using SGFlooringCorp.Models;
using SGFlooringCorp.UI.Workflows;

namespace SGFlooringCorp.UI.Utilities
{
    public class UserInteractions
    {

        public static int PromptForChoice(string message, int lowerBound, int upperBound)
        {
            bool validInput = false;
            int output = 0;

            while (!validInput)
            {
                Console.Write(message);
                validInput = Int32.TryParse(Console.ReadLine(), out output);

                if (!validInput)
                {
                    Console.WriteLine("That is not a valid choice");
                }
                else
                {
                    if (output < lowerBound || output > upperBound)
                    {
                        validInput = false;
                        Console.WriteLine("Choose an option {0}-{1}", lowerBound, upperBound);
                    }
                }
            }

            return output;
        }

        public static void PressKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static string GetRequiredStringFromUser()
        {
            string input = "";
            bool validInput = false;

            do
            {

            } while (!validInput);
            return input;
        }

        public static DateTime GetDateFromUser()
        {
            do
            {
                Console.WriteLine("Enter the date of the order you wish to look up ");
                Console.Write("in this format(MM/DD/YYYY): ");
                string input = Console.ReadLine();
                DateTime thisDate;

                if (DateTime.TryParse(input, out thisDate))
                {
                    thisDate = DateTime.Parse(input);
                    return thisDate;
                }

                Console.WriteLine("That was not a valid date.  Press any key to continue...");
                Console.ReadKey();
            } while (true);
        }

        public static OrderRequest PromptForValidOrderDate(OrderRequest orderRequest)
        {
            var ops = OperationsFactory.CreateOrderOperations();

            Console.Clear();
            do
            {
                Console.Clear();
                var orderDate = GetDateFromUser();
                var response = ops.ListAll(orderDate);

                if (!response.Success)
                {
                    Console.WriteLine("\n*** ERROR: {0} ***\n",response.Message.ToUpper());
                    PressKeyToContinue();
                }
                else
                {
                    orderRequest.OrderDate = orderDate;
                    return orderRequest;
                }
            } while (true);
        }


        public static OrderRequest PromptForValidOrderNumber(OrderRequest orderRequest)
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var response = new Response<Order>();

            do
            {
                var orderNumber = GetValidIntFromUser("Please enter an order number");
                orderRequest.Order = new Order();
                orderRequest.Order.OrderNumber = orderNumber;
                response = ops.GetSelectedOrder(orderRequest);
                orderRequest.Order = response.Data;
                if (!response.Success)
                    Console.Write("{0}. ", response.Message);
            } while (!response.Success);

            return orderRequest;


        }

        public static int GetValidIntFromUser(string message)
        {
            int num = -1;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write("{0}", message);
                validInput = int.TryParse(Console.ReadLine(), out num);

                if (!validInput)
                {
                    Console.Write("Not a valid number! ");
                }
            }
            return num;
        }

        public static decimal PromptForDecimal(string message, string mode = "Add")
        {
            bool validInput = false;
            decimal output = 0;

            while (!validInput)
            {
                Console.Write("{0}", message);
                var input = Console.ReadLine();

                if (mode == "Edit" && String.IsNullOrWhiteSpace(input))
                    return -1;

                validInput = Decimal.TryParse(input, out output);

                if (!validInput)
                {
                    Console.WriteLine("That is not a valid decimal!");
                }
            }

            return output;
        }

        public static string PromptForValidState(string message)
        {
            bool validInput = false;
            string output = "";
            var taxOperations = OperationsFactory.CreateTaxOperations();

            while (!validInput)
            {
                Console.Write("{0}",message);
                output = Console.ReadLine();

                if (!taxOperations.IsValidState(output))
                {
                    Console.Write("That is not a state we sell in. ");
                }
                else
                {
                    validInput = true;
                }
            }

            return output;
        }

        public static string PromptForValidProductType(string message)
        {
            bool validInput = false;
            string output = "";
            var productOperations = OperationsFactory.CreateProductOperations();

            while (!validInput)
            {
                Console.Write("{0}", message);
                output = Console.ReadLine();

                if (!productOperations.IsValidProductType(output))
                {
                    Console.Write("That is not a valid product type. ");
                }
                else
                {
                    validInput = true;
                }
            }

            return output;
        }


        public static string PromptForConfirmation(string message)
        {
            bool validInput = false;
            string output = "";

            while (!validInput)
            {
                Console.Write("{0}",message);
                output = Console.ReadLine();


                if (String.IsNullOrEmpty(output))
                {
                    Console.WriteLine("Please make a selection.");
                }
                else
                {
                    output = output.Substring(0, 1).ToUpper();
                    if (output == "Y" || output == "N")
                        validInput = true;
                }
            }

            return output;
        }


    }
}
