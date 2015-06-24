using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SGFlooringCorp.BLL;
using SGFlooringCorp.Models;

namespace SGFlooringCorp.Tests
{
    [TestFixture]
   public class OrderOperationsTests
    {
        [Test]
        public void FoundFileSuccess()
        {
            var ops = new OrderOperations();
            var response = ops.GetFile("01132015");
            Assert.IsTrue(response.Success);

        }

        [Test]
        public void GetAllOrdersSuccess()
        {
            var ops = new OrderOperations();
            var response = ops.GetAllOrders("01132015");
            Assert.IsTrue(response.Success);
        }
    }
}
