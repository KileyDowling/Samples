﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Data;
using SGFlooringCorp.Models;
using System.IO;


namespace SGFlooringCorp.BLL
{
    public class OrderOperations
    {
        public Response<List<Order>> GetAllOrders(string orderDate)
        {
            var response = new Response<List<Order>>();
            var validFile = GetFile(orderDate);

            try
            {
                if (validFile.Success)
                {
                    string filePath = validFile.Data;
                    var repo = new OrderRepository();
                    response.Data = repo.GetAllOrders(filePath);
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

        public Response<string> GetFile(string filePathWithDate)
        {
            var repo = new OrderRepository();

            var response = new Response<string>();

            try
            {
                var orderFilePath = repo.CreateFilePath(filePathWithDate);
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


        public void CreateFile(string dateToday)
        {



        }

        public Response<Order> DeleteOrder(OrderRequest request)
        {
            var response = new Response<Order>();
            var orderRepo = new OrderRepository();

            try
            {
                var orders = orderRepo.RemoveOrder(request);
                if (orders != null)
                {
                    response.Success = true;
                    response.Message = "Order successfully deleted!";

                }
            }

            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }


}
