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
            //var ops = new OrderOperations();
            //var response = ops.GetFile(new DateTime(2015, 24, 02));
            //Assert.IsTrue(response.Success);
        }


        [Test]
        public void FoundFileFailure()
        {
        //    var ops = new OrderOperations();
        //    var response = ops.GetFile(new DateTime(2015, 02, 02));
        //    Assert.IsFalse(response.Success);

        }

        [Test]
        public void GetAllOrdersSuccess()
        {
        //    var ops = new OrderOperations();
        //    var response = ops.ListAll(new DateTime(2015, 24, 02));
        //    Assert.IsTrue(response.Success);

        }

        [Test]
        public void GetAllOrdersFailure()
        {
            //var ops = new OrderOperations();
            //var response = ops.ListAll(new DateTime(2015, 04, 02));
            //Assert.IsFalse(response.Success);

        }
    }
}