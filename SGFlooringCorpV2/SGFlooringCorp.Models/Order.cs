using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooringCorp.Models
{
    public class Order
    {
        //public string OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public string StateAbbreviation { get; set; }
        public decimal TaxRate  { get; set; }
        public string ProductType  { get; set; }

        //the actual properties next should be decimals, but the dummy data is int
        public decimal Area { get; set; }
        public decimal CostPerSquareFoot { get; set; }
        public decimal LaborCostPerSquareFoot { get; set; }
        public decimal MaterialCost { get; set; }
        public decimal TotalLaborCost { get; set; }
        public decimal TotalTax { get; set; }
        public decimal Total  { get; set; }
    }

    
}
