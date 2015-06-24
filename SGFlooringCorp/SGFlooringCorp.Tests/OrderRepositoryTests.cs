using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SGFlooringCorp.Data;

namespace SGFlooringCorp.Tests
{
    [TestFixture]
    public class OrderRepositoryTests
    {
        [Test]
        public void CanLoadOrders()
        {
            var repo = new OrderRepository();
            var orders = repo.GetAllOrders(@"DataFiles\Orders_01132015.txt");
            var customerName = orders.Where(x => x.OrderNumber == "3").Select(y => y.CustomerName);
            var orderNumber = orders.Where(x => x.OrderNumber == "3").Select(y => y.OrderNumber);


            Assert.AreEqual(5, orders.Count);
            Assert.IsTrue(true, "John Smith", customerName);
            Assert.IsTrue(true, "3", customerName);
        }

        [Test]
        public void CanCreateFilePath()
        {
            var repo = new OrderRepository();
            var fileName = repo.CreateFilePath("01012015");
            Assert.AreEqual(@"DataFiles\Orders_01012015.txt", fileName);
        }

    
    }
}
