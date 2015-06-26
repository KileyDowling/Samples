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
    public class OrderOperationsTests
    {
        [Test]
        public void FoundFileSuccess()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var response = ops.GetFile(new DateTime(2015, 02, 24));
            Assert.IsTrue(response.Success);
        }

        [Test]
        public void FoundFileFailure()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var response = ops.GetFile(new DateTime(2015, 02, 02));
            Assert.IsFalse(response.Success);

        }

        [Test]
        public void GetAllOrdersSuccess()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var response = ops.ListAll(new DateTime(2015, 02, 24));
            Assert.IsTrue(response.Success);

        }

        [Test]
        public void GetAllOrdersFailure()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var response = ops.ListAll(new DateTime(2015, 04, 02));
            Assert.IsFalse(response.Success);

        }

        [Test]
        public void CreateOrderSuccess()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var orderRequest = new OrderRequest();
            orderRequest.Order = new Order();
            orderRequest.OrderDate = new DateTime(2015,07,01);
            orderRequest.Order.CustomerName = "Vishy Marocha";
            var response = ops.CreateOrder(orderRequest);
            Assert.AreEqual(true,response.Success);
            Assert.AreEqual("Vishy Marocha", response.Data.CustomerName);
        }

        [Test]
        public void DeleteOrderSuccess()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var orderRequest = new OrderRequest();
            orderRequest.Order = new Order();
            orderRequest.OrderDate = new DateTime(2015, 07, 01);
            orderRequest.Order.OrderNumber = 1;
            var response = ops.DeleteOrder(orderRequest);
            Assert.AreEqual(true, response.Success);
            Assert.AreEqual("Order successfully deleted!", response.Message);
            Assert.AreEqual(null, response.Data);
            ;

        }

        [Test]
        public void GetSelectedOrderSuccess()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var orderRequest = new OrderRequest();
            orderRequest.OrderDate = new DateTime(2015,07,01);
            orderRequest.Order = new Order();
            orderRequest.Order.OrderNumber = 7;
            var response = ops.GetSelectedOrder(orderRequest);
            Assert.AreEqual(true,response.Success);
            Assert.AreEqual(7, response.Data.OrderNumber);
            Assert.AreEqual("Vishy Marocha", response.Data.CustomerName);





        }

        [Test]
        public void EditSelectedOrderSuccess()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var oldOrder = new OrderRequest();
            var editedOrder = new OrderRequest();
            oldOrder.Order = new Order();
            editedOrder.Order = new Order();
            oldOrder.OrderDate = new DateTime(2015, 07, 01);
            editedOrder.OrderDate = new DateTime(2015, 07, 01);
            oldOrder.Order.OrderNumber = 3;
            editedOrder.Order.OrderNumber = 3;
            editedOrder.Order.CustomerName = "Kiwi Marocha";
            var response = ops.EditSelectedOrder(oldOrder, editedOrder);
            Assert.AreEqual(true, response.Success);
            Assert.AreEqual("Kiwi Marocha", response.Data.CustomerName);

        }
    }
}