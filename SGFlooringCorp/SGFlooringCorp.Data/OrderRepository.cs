using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Models;

namespace SGFlooringCorp.Data
{
    public class OrderRepository
    {
        private string _filePath="";
        //need to assign filepath variable string returned from GetFile();

       public string CreateFilePath(string orderDate)
       {
           string fileWithDateName = @"DataFiles\Orders_";
           fileWithDateName+= orderDate;
           fileWithDateName += ".txt";

           return fileWithDateName;
          
       }

        public List<Order> GetAllOrders(string fileName)
        {
            List<Order> orders = new List<Order>();

            var reader = File.ReadAllLines(fileName);

            for (int i = 1; i < reader.Length; i++)
            {
                var columns = reader[i].Split(',');

                var order = new Order();
                //OrderNumber,CustomerName,State,TaxRate,ProductType,Area,CostPerSquareFoot,LaborCostPerSquareFoot,
                //MaterialCost,TotalLaborCost,TotalTax,Total
                
                order.OrderNumber = columns[0];
                order.CustomerName = columns[1];
                order.State = columns[2];
                order.TaxRate = decimal.Parse(columns[3]);
                order.ProductType = columns[4];
                order.Area = decimal.Parse(columns[5]);
                order.CostPerSquareFoot = decimal.Parse(columns[6]);
                order.LaborCostPerSquareFoot = decimal.Parse(columns[7]);
                order.MaterialCost = decimal.Parse(columns[8]);
                order.TotalLaborCost = decimal.Parse(columns[9]);
                order.TotalTax = decimal.Parse(columns[10]);
                order.Total = decimal.Parse(columns[11]);            
                
                orders.Add(order);
        }
            return orders;
        }


    }
}
