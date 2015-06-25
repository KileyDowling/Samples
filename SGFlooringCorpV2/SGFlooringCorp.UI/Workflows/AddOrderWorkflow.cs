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
    class AddOrderWorkflow
    {
        public void Execute()
        {

        }

        public OrderRequest GenerateOrderInformation(OrderRequest request)
        {
            request.OrderDate = DateTime.Today;

            //need to create an order number generator in BLL
            request.Order.OrderNumber ="1";

            //user requested
            request.Order.CustomerName = UserInteractions.GetRequiredStringFromUser();
            request.Order.State = UserInteractions.GetStateAbbreviation();
            request.Order.ProductType = "";
            request.Order.Area = 0;

            //develop access to taxrates, etc.
            request.Order.TotalTax = 0;
            request.Order.CostPerSquareFoot = 0;
            request.Order.LaborCostPerSquareFoot = 0;
            request.Order.TotalLaborCost = 0;
            request.Order.MaterialCost = 0;
            request.Order.Total = 0;


            return request;



        }
    }
}
