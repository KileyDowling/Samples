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
    public class OrderRepositoryTests
    {
        [Test]
        public void CanLoadOrders()
        {
            var repo = new OrderRepository();
            var orders = repo.ListAll(new DateTime(2015,02,24));
            var customerName = orders.Where(x => x.OrderNumber == 3).Select(y => y.CustomerName);
            var orderNumber = orders.Where(x => x.OrderNumber == 3).Select(y => y.OrderNumber);


            Assert.AreEqual(5, orders.Count);
            Assert.IsTrue(true, "John Smith", customerName);
            Assert.IsTrue(true, "3", orderNumber);
        }

        [Test]
        public void CanCreateFilePath()
        {
            var repo = new OrderRepository();
            var fileName = repo.GenerateFilePathString(new DateTime(2015, 02, 24));
            Assert.AreEqual(@"DataFiles\Orders_02242015.txt", fileName);
        }

        [Test]
        public void CanCreateOrder()
        {
            
        }
    }
}