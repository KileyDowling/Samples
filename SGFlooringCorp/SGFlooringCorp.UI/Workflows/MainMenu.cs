using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooringCorp.UI.Workflows
{
    public class MainMenu
    {
        public void Execute()
        {
            do
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
                Console.Write("\n\nEnter choice: ");
                string input = Console.ReadLine();

                if (input == "5")
                    break;

                ProcessUserChoice(input);
            } while (true);
        }

        public void ProcessUserChoice(string input)
        {
            switch (input)
            {
                case "1":
                    var displayOrdersWorkflow = new DisplayOrderWorkflow();
                    displayOrdersWorkflow.Execute();
                    break;
                case "2":
                    var addOrderWorkflow = new AddOrderWorkflow();
                    addOrderWorkflow.Execute();
                    break;
                case "3":
                    var editOrderWorkflow = new EditOrderWorkflow();
                    editOrderWorkflow.Execute();
                    break;
                case "4":
                    var removeOrderWorkflow = new RemoveOrderWorkflow();
                    removeOrderWorkflow.Execute();
                    break;
            }
        }
    }
}
