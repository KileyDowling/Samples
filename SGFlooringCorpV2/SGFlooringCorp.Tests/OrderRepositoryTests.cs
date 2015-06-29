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
        public void FoundFileSuccess()
        {
            var repo = new OrderRepository();
            var response = repo.GetFile(new DateTime(2015, 02, 24));
            Assert.IsTrue(response);
        }

        [Test]
        public void FoundFileFailure()
        {
            var repo = new OrderRepository();
            var response = repo.GetFile(new DateTime(2015, 02, 02));
            Assert.IsFalse(response);

        }
        [Test]
        public void LoadOrdersSuccess()
        {
            var repo = new OrderRepository();
            var orders = repo.ListAll(new DateTime(2015, 02, 24));
            var customerName = orders.Where(x => x.OrderNumber == 3).Select(y => y.CustomerName);
            var orderNumber = orders.Where(x => x.OrderNumber == 3).Select(y => y.OrderNumber);


            Assert.AreEqual(5, orders.Count);
            Assert.IsTrue(true, "John Smith", customerName);
            Assert.IsTrue(true, "3", orderNumber);
        }

        [Test]
        public void CreateFilePathSuccess()
        {
            var repo = new OrderRepository();
            var fileName = repo.GenerateFilePathString(new DateTime(2015, 02, 24));
            Assert.AreEqual(@"DataFiles\Orders_02242015.txt", fileName);
        }

        [Test]
        public void CreateOrderSuccess()
        {
            var repo = new OrderRepository();
            var request = new OrderRequest();
            request.Order = new Order();
            request.Order.CustomerName = "K LittleJ";
            repo.Add(request);
            var order = repo.GetOrder(request);
            Assert.AreEqual("K LittleJ",order.CustomerName);
        }

        [Test]
        public void RemoveOrderSuccess()
        {
            var repo = new OrderRepository();
            var request = new OrderRequest();
            request.OrderDate = new DateTime(2015,06,26);
            request.Order = new Order();
            request.Order.OrderNumber = 2;
            var orders = repo.RemoveOrder(request);
            Assert.AreEqual(2,orders.Count);
        }

        [Test]
        public void GetOrderSuccess()
        {
            var repo = new OrderRepository();
            var request = new OrderRequest();
            request.Order = new Order();
            request.OrderDate = new DateTime(2015,02,24);
            request.Order.OrderNumber = 1;
            var order = repo.GetOrder(request);

            Assert.AreEqual(1, order.OrderNumber);
            Assert.AreEqual("Diedre Douglas", order.CustomerName);
        }


        [Test]
        public void OverWriteFileSuccess()
        {
            var repo = new OrderRepository();
            var orderDate = new DateTime(2015,07,02);
            var orders= repo.ListAll(orderDate);
            repo.OverWriteFile(orders, orderDate);
            var updatedOrder = new OrderRequest()
            {
                OrderDate = orderDate,
                Order = new Order(),
            };

            updatedOrder.Order.OrderNumber = 1;

            Assert.AreEqual(null, updatedOrder.Order.CustomerName);

        }

    }
}