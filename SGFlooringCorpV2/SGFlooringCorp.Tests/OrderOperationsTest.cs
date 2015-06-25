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
            var orders = repo.GetAllOrders(new DateTime(2015, 24, 02));
            var customerName = orders.Where(x => x.OrderNumber == "3").Select(y => y.CustomerName);
            var orderNumber = orders.Where(x => x.OrderNumber == "3").Select(y => y.OrderNumber);


            Assert.AreEqual(5, orders.Count);
            Assert.IsTrue(true, "John Smith", customerName);
            Assert.IsTrue(true, "3", orderNumber);
        }

        [Test]
        public void CanCreateFilePath()
        {
            var repo = new OrderRepository();
            var fileName = repo.GenerateFilePathString(new DateTime(2015, 24, 02));
            Assert.AreEqual(@"DataFiles\Orders_01012015.txt", fileName);
        }


    }
}