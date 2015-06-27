using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.UI.Utilities;

namespace SGFlooringCorp.UI.Workflows
{
    public class MenuWorkflow
    {
        private bool _active = true;

        public void Execute()
        {
            while (_active)
            {
                Screens.MainMenu();
                GetUserChoice();
            }
        }

        public void GetUserChoice()
        {
            int userChoice = UserInteractions.PromptForChoice("Please enter a number (1-5): ", 1, 5);
            switch (userChoice)
            {
                case 1:
                    var displayOrdersWorkflow = new DisplayOrderWorkflow();
                    displayOrdersWorkflow.Execute();
                    break;
                case 2:
                    var addOrderWorkflow = new AddOrderWorkflow();
                    addOrderWorkflow.Execute();
                    break;
                case 3:
                    var editOrderWorkflow = new EditOrderWorkflow();
                    editOrderWorkflow.Execute();
                    break;
                case 4:
                    var removeOrderWorkflow = new RemoveOrderWorkflow();
                    removeOrderWorkflow.Execute();
                    break;
                default:
                    _active = false;
                    break;
            }
        }
    }
    }

