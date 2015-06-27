using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SGFlooringCorp.BLL;
using SGFlooringCorp.Data;
using SGFlooringCorp.Models;

namespace SGFlooringCorp.Tests
{
	[TestFixture]
	public class ProductOperationsTest
	{
		[Test]
		public void ListAllSuccess()
		{
			var ops = OperationsFactory.CreateProductOperations();
			var products = ops.ListAll();
			Assert.AreEqual(2,products.Count);
		}

		[Test]
		public void GetProductTypeSuccess()
		{
			var ops = OperationsFactory.CreateProductOperations();
			var productType = ops.GetProductType("Hardwood");
			Assert.AreEqual("Hardwood", productType);
		}

		[Test]
		public void isValidProductTypeSuccess()
		{
			var ops = OperationsFactory.CreateProductOperations();
			var valid = ops.IsValidProductType("Hardwood");
			var invalid = ops.IsValidProductType("Wood");
			Assert.IsTrue(valid);
			Assert.IsFalse(invalid);
		}

		[Test]
		public void CostPerSquareFeetSuccess()
		{
			var ops = OperationsFactory.CreateProductOperations();
			decimal costPerSqFt = ops.GetCostPerSquareFoot("Hardwood");
			Assert.AreEqual(7.55, costPerSqFt);
		}

		[Test]
		public void LaborCostPerSqFt()
		{
			var ops = OperationsFactory.CreateProductOperations();
			decimal laborCostPerSqFt = ops.GetLaborCostPerSquareFoot("Laminate");
			Assert.AreEqual(2.96,laborCostPerSqFt);
		}

		[Test]
		public void GetProductCostsSuccess()
		{
			var ops = OperationsFactory.CreateProductOperations();
			var response = new Response<Order>();
			var request = new OrderRequest()
			{
				Order = new Order()
				{
					ProductType = "Hardwood",
					CustomerName =  "Lucy",
					StateAbbreviation = "OH",
					Area = 5,
					OrderNumber = 10,
				},
				OrderDate = new DateTime(2015,02,24)
			};

			response = ops.GetProductCosts(request);
			Assert.IsTrue(response.Success);
		}

		[Test]
		public void CalculateLaborCostSuccess()
		{
			var ops = OperationsFactory.CreateProductOperations();
			var request = new OrderRequest()
			{
				OrderDate = new DateTime(2015, 06, 27),
				Order = new Order()
				{
					OrderNumber = 1,
					CustomerName = "Lacy",
					Area = 10,
					ProductType = "Laminate",

				}

			};
			request.Order.LaborCostPerSquareFoot = ops.GetLaborCostPerSquareFoot(request.Order.ProductType);
			decimal cost = ops.CalculateLaborCost(request);
			Assert.AreEqual(29.6, cost);
		}

		[Test]
		public void CalculateMaterialCostSuccess()
		{
			var ops = OperationsFactory.CreateProductOperations();
			var request = new OrderRequest()
			{
				OrderDate = new DateTime(2015, 06, 27),
				Order = new Order()
				{
					OrderNumber = 1,
					CustomerName = "Lacy",
					Area = 10,
					ProductType = "Laminate",

				}

			};
			request.Order.CostPerSquareFoot = ops.GetCostPerSquareFoot(request.Order.ProductType);
			decimal cost = ops.CalculateMaterialCost(request);
			Assert.AreEqual(54.8, cost);
		}

		[Test]
		public void CalculateTotalSuccess()
		{
			var ops = OperationsFactory.CreateProductOperations();
			var request = new OrderRequest()
			{
				OrderDate = new DateTime(2015, 06, 27),
				Order = new Order()
				{
					OrderNumber = 1,
					CustomerName = "Lacy",
					Area = 10,
					ProductType = "Hardwood",
					StateAbbreviation = "OH",
					TaxRate = 0.065M,
					CostPerSquareFoot = 7.55M,
					LaborCostPerSquareFoot = 4.12M,
					MaterialCost = 75.5M,
					TotalLaborCost = 41.2M,
					TotalTax =  7.59M
				}

			};
			decimal total = ops.CalculateTotal(request);
			Assert.AreEqual(124.29M,total);


		}

		[Test]
		public void CalculateTaxTotalSuccess()
		{
			var ops = OperationsFactory.CreateProductOperations();
			var request = new OrderRequest()
			{
				OrderDate = new DateTime(2015, 06, 27),
				Order = new Order()
				{
					OrderNumber = 1,
					CustomerName = "Lacy",
					Area = 10,
					ProductType = "Hardwood",
					StateAbbreviation = "OH",
					TaxRate = 0.065M,
					CostPerSquareFoot = 7.55M,
					LaborCostPerSquareFoot = 4.12M,
					MaterialCost = 75.5M,
					TotalLaborCost = 41.2M,
				}

			};
			decimal total = ops.CalculateTax(request);
			Assert.AreEqual(7.5855M, total);
		}
	}
}
