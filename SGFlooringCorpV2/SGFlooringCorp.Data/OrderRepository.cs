using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Models;
using SGFlooringCorp.Models.Interfaces;

namespace SGFlooringCorp.Data
{
    public class OrderRepository : IOrderRepository
    {
        public string GenerateFilePathString(DateTime orderDate)
        {
            string fileWithDateName = @"DataFiles\Orders_";
            fileWithDateName += orderDate.ToString("MMddyyyy");
            fileWithDateName += ".txt";

            return fileWithDateName;
        }

        public List<Order> ListAll(DateTime orderDate)
        {
            List<Order> orders = new List<Order>();

            string orderFilePath = GenerateFilePathString(orderDate);

            if (File.Exists(orderFilePath))
            {
                var reader = File.ReadAllLines(orderFilePath);

                for (int i = 1; i < reader.Length; i++)
                {
                    var columns = reader[i].Split(',');

                    var order = new Order();
                    //OrderNumber,CustomerName,State,TaxRate,ProductType,Area,CostPerSquareFoot,LaborCostPerSquareFoot,
                    //MaterialCost,TotalLaborCost,TotalTax,Total

                    order.OrderNumber = int.Parse(columns[0]);
                    order.CustomerName = columns[1];
                    order.StateAbbreviation = columns[2];
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
            return null;
        }

        public void Add(OrderRequest orderToAddRequest)
        {

            var orders = ListAll(orderToAddRequest.OrderDate);

            if (orders == null)
            {
                orders = new List<Order>();
            }

            orders.Add(orderToAddRequest.Order);
            OverWriteFile(orders, orderToAddRequest.OrderDate);

        }


        public List<Order> RemoveOrder(OrderRequest orderToDeleteRequest)
        {
            var orders = ListAll(orderToDeleteRequest.OrderDate);

            if (orders.Count != 0)
            {
                var orderToReplace = orders.FirstOrDefault(x => x.OrderNumber == orderToDeleteRequest.Order.OrderNumber);
                orders.Remove(orderToReplace);
                //TODO: delete the file if there are no more orders
            }

            else
            {
                orders = null;
            }
            OverWriteFile(orders, orderToDeleteRequest.OrderDate);
            return orders;
        }

        public void OverWriteFile(List<Order> orders, DateTime orderDate)
        {
            var filePath = GenerateFilePathString(orderDate);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (var writer = File.CreateText(filePath))
            {
                writer.WriteLine(
                    "OrderNumber,CustomerName,State,TaxRate,ProductType,Area,CostPerSquareFoot,LaborCostPerSquareFoot,MaterialCost,TotalLaborCost,TotalTax,Total");
                foreach (var order in orders)
                {
                    writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                        order.OrderNumber,
                        order.CustomerName,
                        order.StateAbbreviation,
                        order.TaxRate,
                        order.ProductType,
                        order.Area,
                        order.CostPerSquareFoot,
                        order.LaborCostPerSquareFoot,
                        order.MaterialCost,
                        order.TotalLaborCost,
                        order.TotalTax,
                        order.Total);
                }




            }
        }

        public Order GetOrder(OrderRequest orderRequest)
        {
            var orders = ListAll(orderRequest.OrderDate);
            try
            {
                if (orders != null)
                {
                    var selectedOrder = orders.First(x => x.OrderNumber == orderRequest.Order.OrderNumber);
                    return selectedOrder;

                }
            }
            catch (Exception)
            {

                return null;
            }
            return null;
        }

        public bool GetFile(DateTime orderDate)
        {
                bool fileExists;
                var orderFilePath = GenerateFilePathString(orderDate);
                if (!File.Exists(orderFilePath))
                {
                    fileExists = false;
                }
                else
                {
                    fileExists = true;
                }
            

            return fileExists;
        }
    }
}