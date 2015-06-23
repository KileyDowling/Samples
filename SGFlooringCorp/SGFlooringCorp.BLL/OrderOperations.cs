using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Data;
using SGFlooringCorp.Models;


namespace SGFlooringCorp.BLL
{
    public class OrderOperations
    {
        public Response<Order> GetOrder(string Date, string OrderNumber)
        {
            var repo = new OrderRepository();

            try
            {

                //var order = repo.GetOrderRepository();
            }
        }
    }
}
