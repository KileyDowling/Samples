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
	   public string GenerateFilePathString(DateTime orderDate)
	   {
		   string fileWithDateName = @"DataFiles\Orders_";
		   fileWithDateName+= orderDate.ToString("mmddyyyy");
		   fileWithDateName += ".txt";

		   return fileWithDateName;
	   }

		public List<Order> GetAllOrders(DateTime orderDate)
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
			return null;
		}

		public List<Order> AddOrder(OrderRequest orderToAddRequest)
		{
			
			var orders = GetAllOrders(orderToAddRequest.OrderDate);

			if (orders == null)
			{
				orders = new List<Order>();
			}

			orders.Add(orderToAddRequest.Order);
			OverWriteFile(orders,orderToAddRequest.OrderDate);

			return orders;
		}

		public List<Order> RemoveOrder(OrderRequest orderToDeleteRequest)
		{
			string orderDate = orderToDeleteRequest.OrderDate.ToString("mmddyyyy");
			var orders = GetAllOrders(orderToDeleteRequest.OrderDate);

			if (orders != null)
			{
				var orderToReplace = orders.FirstOrDefault(x => x.OrderNumber == orderToDeleteRequest.Order.OrderNumber);
				orders.Remove(orderToReplace);
				//TODO: delete the file if there are no more orders
			}

			OverWriteFile(orders, orderToDeleteRequest.OrderDate);
			return orders;
		}

		private void OverWriteFile(List<Order> orders, DateTime orderDate)
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
						order.State,
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


	}
}
