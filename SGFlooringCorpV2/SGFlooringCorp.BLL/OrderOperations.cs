using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Data;
using SGFlooringCorp.Models;
using System.IO;
using SGFlooringCorp.Models.Interfaces;


namespace SGFlooringCorp.BLL
{
    public class OrderOperations
    {
        private IOrderRepository _orderRepo;

        public OrderOperations(IOrderRepository myRepo)
        {
            _orderRepo = myRepo;
        }

        public Response<List<Order>> ListAll(DateTime orderDate)
        {
            var response = new Response<List<Order>>();
            var validFile = GetFile(orderDate);

            try
            {
                if (validFile.Success)
                {
                    var repo = new OrderRepository();
                    response.Data = repo.ListAll(orderDate);
                    response.Success = true;

                }
                else
                {
                    response.Success = false;
                    response.Message = "Order date not found";
                }

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<string> GetFile(DateTime orderDate)
        {
            var repo = new OrderRepository();

            var response = new Response<string>();

            try
            {
                var orderFilePath = repo.GenerateFilePathString(orderDate);
                if (!File.Exists(orderFilePath))
                {
                    response.Success = false;
                    response.Message = "Order date not found";
                }
                else
                {
                    response.Success = true;
                    response.Data = orderFilePath;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<Order> CreateOrder(OrderRequest orderToAddRequest)
        {
            var response = new Response<Order>();
            try
            {
                var orders = _orderRepo.ListAll(orderToAddRequest.OrderDate);

                int orderNumber = 0;

                if (orders != null)
                    orderNumber = orders.Max(o => o.OrderNumber);

                orderNumber++;

                orderToAddRequest.Order.OrderNumber = orderNumber;

                _orderRepo.Add(orderToAddRequest);

                response.Success = true;
                response.Data = orderToAddRequest.Order;


            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public Response<Order> DeleteOrder(OrderRequest request)
        {
            var response = new Response<Order>();
            var orderRepo = new OrderRepository();

            var listAll = orderRepo.ListAll(request.OrderDate);

            try
            {
                if (listAll.Count > 0)
                { 
                    orderRepo.RemoveOrder(request);
                    response.Success = true;
                    response.Message = "Order successfully deleted!";
                }
                else
                {

                    response.Success = false;
                    response.Message = "Order date not found";
                }
                
            }

            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<Order> GetSelectedOrder(OrderRequest selectedOrder)
        {
            var response = new Response<Order>();
            var orderRepo = new OrderRepository();
            Order order = orderRepo.GetOrder(selectedOrder);
            if (order !=null)
            {
                response.Success = true;
                response.Data = order;
            }
            else
            {
                response.Success = false;
                response.Message = "Order not found";
            }

            return response;
        }

        public Response<Order> EditSelectedOrder(OrderRequest selecteOrder, OrderRequest editedOrderRequest)
        {
            var response = new Response<Order>();
            
            var selectedOrderResponse = GetSelectedOrder(selecteOrder);
            if (!selectedOrderResponse.Success)
            {
                response.Message = selectedOrderResponse.Message;
                return response;

            }
            else
            {
                try
                {

                    if (selectedOrderResponse.Success)
                    {
                        selecteOrder.Order = selectedOrderResponse.Data;
                        var repo = new OrderRepository();
                        response.Data = repo.EditOrder(selecteOrder, editedOrderRequest);

                        response.Success = true;
                        return response;
                    }

                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = ex.Message;
                }
            }
          
            return response;
        }
    }
}
