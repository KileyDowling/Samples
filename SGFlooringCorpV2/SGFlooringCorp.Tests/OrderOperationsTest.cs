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
            orderRequest.OrderDate = new DateTime(2015,07,05);
            orderRequest.Order.CustomerName = "Vishy Marocha";
            orderRequest.Order.StateAbbreviation = "PA";
            orderRequest.Order.ProductType = "Hardwood";
            orderRequest.Order.Area = 5;
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
            orderRequest.Order.OrderNumber = 8;
            var response = ops.DeleteOrder(orderRequest);
            Assert.AreEqual(true, response.Success);
            Assert.AreEqual("Order successfully deleted!", response.Message);
        }

        [Test]
        public void DeleteOrderFailure()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var orderRequest = new OrderRequest();
            orderRequest.Order = new Order();
            orderRequest.OrderDate = new DateTime(2015, 07, 02);
            orderRequest.Order.OrderNumber = 1;
            var response = ops.DeleteOrder(orderRequest);
            Assert.AreEqual(false, response.Success);
            Assert.AreEqual(null, response.Data);
        }

        [Test]
        public void GetSelectedOrderSuccess()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var orderRequest = new OrderRequest();
            orderRequest.OrderDate = new DateTime(2015,07,01);
            orderRequest.Order = new Order();
            orderRequest.Order.OrderNumber = 12;
            var response = ops.GetSelectedOrder(orderRequest);
            Assert.AreEqual(true,response.Success);
            Assert.AreEqual(12, response.Data.OrderNumber);
            Assert.AreEqual("Vishy Marocha", response.Data.CustomerName);
        }

        [Test]
        public void GetSelectedOrderFailure()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var orderRequest = new OrderRequest();
            orderRequest.OrderDate = new DateTime(2015, 07, 02);
            orderRequest.Order = new Order();
            orderRequest.Order.OrderNumber = 1;
            var response = ops.GetSelectedOrder(orderRequest);
            Assert.AreEqual(false, response.Success);
            Assert.AreEqual("Order not found", response.Message);
        }


        [Test]
        public void EditSelectedOrderSuccess()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var oldOrder = new OrderRequest();
            var editedOrder = new OrderRequest();
            oldOrder.Order = new Order();
            editedOrder.Order = new Order();
            oldOrder.OrderDate = new DateTime(2015, 01, 13);
            editedOrder.OrderDate = new DateTime(2015, 01, 13);
            oldOrder.Order.OrderNumber = 3;
            editedOrder.Order.OrderNumber = 3;
            editedOrder.Order.CustomerName = "Kiwi M";
            editedOrder.Order.StateAbbreviation = "OH";
            editedOrder.Order.ProductType = "Hardwood";
            editedOrder.Order.Area = 5;
            var response = ops.EditSelectedOrder(oldOrder, editedOrder);
            Assert.AreEqual(true, response.Success);
            Assert.AreEqual("Kiwi M", response.Data.CustomerName);

        }

        [Test]
        public void EditSelectedOrderFailureNonExistingOrderDate()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var oldOrder = new OrderRequest();
            var editedOrder = new OrderRequest();
            oldOrder.Order = new Order();
            editedOrder.Order = new Order();

            oldOrder.OrderDate = new DateTime(2015, 07, 03);
            editedOrder.OrderDate = new DateTime(2015, 07, 03);

            editedOrder.Order.OrderNumber = 3;
            editedOrder.Order.CustomerName = "Kiwi Marocha";
            var response = ops.EditSelectedOrder(oldOrder, editedOrder);
            Assert.AreEqual(false, response.Success);

        }
        [Test]
        public void EditSelectedOrderFailureExistingOrderDateNonExistingOrderNum()
        {
            var ops = OperationsFactory.CreateOrderOperations();
            var oldOrder = new OrderRequest();
            var editedOrder = new OrderRequest();
            oldOrder.Order = new Order();
            editedOrder.Order = new Order();

            oldOrder.OrderDate = new DateTime(2015, 07, 01);
            editedOrder.OrderDate = new DateTime(2015, 07, 01);

            editedOrder.Order.OrderNumber = 3;
            editedOrder.Order.CustomerName = "Kiwi Marocha";
            var response = ops.EditSelectedOrder(oldOrder, editedOrder);
            Assert.AreEqual(false, response.Success);
            Assert.AreEqual("Order not found", response.Message);

        }
    }
}