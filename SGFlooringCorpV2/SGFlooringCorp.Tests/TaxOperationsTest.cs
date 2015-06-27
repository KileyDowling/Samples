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
    public class TaxOperationsTest
    {
        [Test]
        public void ListAll()
        {
            var ops = OperationsFactory.CreateTaxOperations();
            var taxes = ops.ListAll();
            Assert.AreEqual(2,taxes.Count);
        }

        [Test]
        public void GetRateSuccess()
        {
            var ops = OperationsFactory.CreateTaxOperations();
            decimal rate = ops.GetRate("OH");
            Assert.AreEqual(0.065M, rate);
        }

        [Test]
        public void isValidStateSuccess()
        {
            var ops = OperationsFactory.CreateTaxOperations();
            bool validState = ops.IsValidState("OH");
            bool invalidState = ops.IsValidState("TX");
            Assert.IsTrue(validState);
            Assert.IsFalse(invalidState);


        }

        [Test]
        public void GetTaxSuccess()
        {
            var ops = OperationsFactory.CreateTaxOperations();
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
                    CostPerSquareFoot = 7.55M,
                    LaborCostPerSquareFoot = 4.12M,
                    MaterialCost = 75.5M,
                    TotalLaborCost = 41.2M,
                    TotalTax = 7.59M
                }

            };
            var response = ops.GetTax(request);
            var item = response.Data.TaxRate;
            Assert.IsTrue(response.Success);
            Assert.AreEqual(0.065M,item);
        }

        [Test]
        public void GetTaxFailure()
        {
            var ops = OperationsFactory.CreateTaxOperations();
            var request = new OrderRequest()
            {
                OrderDate = new DateTime(2015, 06, 27),
                Order = new Order()
                {
                    OrderNumber = 1,
                    CustomerName = "Lacy",
                    Area = 10,
                    ProductType = "Hardwood",
                    StateAbbreviation = "TX",
                    CostPerSquareFoot = 7.55M,
                    LaborCostPerSquareFoot = 4.12M,
                    MaterialCost = 75.5M,
                    TotalLaborCost = 41.2M,
                    TotalTax = 7.59M
                }

            };
            var response = ops.GetTax(request);
            Assert.IsFalse(response.Success);
            Assert.AreEqual("Invalid state entered",response.Message);
        }

    }
}
