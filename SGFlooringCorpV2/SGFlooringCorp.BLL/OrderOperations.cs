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
            var repo = new OrderRepository();
            bool validFile = repo.GetFile(orderDate);

            try
            {
                if (validFile)
                {
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

        public int GenerateOrderNumber(List<Order> orders)
        {
            int orderNumber = 0;
            if (orders != null && orders.Count > 0)
            {
                orderNumber = orders.Max(o => o.OrderNumber);
            }

            orderNumber++;

            return orderNumber;
        }
    
        public Response<Order> CreateOrder(OrderRequest orderToAddRequest)
        {
            var response = new Response<Order>();
            try
            {
                var orders = _orderRepo.ListAll(orderToAddRequest.OrderDate);

                if (orderToAddRequest.Order.OrderNumber == 0)
                {
                   orderToAddRequest.Order.OrderNumber = GenerateOrderNumber(orders);
                }
                
                orderToAddRequest = GetTaxRate(orderToAddRequest);
                orderToAddRequest = UpdateCosts(orderToAddRequest);
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
                    var orderInformation = listAll.First(x => x.OrderNumber == request.Order.OrderNumber);
                    response.Data = orderInformation;
                    orderRepo.RemoveOrder(request);
                    response.Success = true;
                    response.Message = "Order successfully deleted!";
                }
                else
                {

                    response.Success = false;
                    response.Message = "There are no orders to delete for this date";
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

        public Response<Order> EditSelectedOrder(OrderRequest oldOrderRequest, OrderRequest editedOrderRequest)
        {
            var response = new Response<Order>();
            
            var selectedOrderResponse = GetSelectedOrder(oldOrderRequest);
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
                        var repo = new OrderRepository();
                        repo.RemoveOrder(oldOrderRequest);
                        var editedOrderResponse = CreateOrder(editedOrderRequest);
                        response.Data = editedOrderResponse.Data;

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

        public OrderRequest GetTaxRate(OrderRequest orderRequest)
        {
            var ops = OperationsFactory.CreateTaxOperations();
            orderRequest.Order.TaxRate = ops.GetRate(orderRequest.Order.StateAbbreviation);

            return orderRequest;

        }

        public OrderRequest UpdateCosts(OrderRequest orderRequest)
        {
            var ops = OperationsFactory.CreateProductOperations();
            orderRequest.Order.LaborCostPerSquareFoot = ops.GetLaborCostPerSquareFoot(orderRequest.Order.ProductType);
            orderRequest.Order.CostPerSquareFoot = ops.GetCostPerSquareFoot(orderRequest.Order.ProductType);
            orderRequest.Order.MaterialCost = ops.CalculateMaterialCost(orderRequest);
            orderRequest.Order.TotalLaborCost = ops.CalculateLaborCost(orderRequest);
            orderRequest.Order.TotalTax = ops.CalculateTax(orderRequest);
            orderRequest.Order.Total = ops.CalculateTotal(orderRequest);



            return orderRequest;

        }
    }
}
