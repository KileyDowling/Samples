using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Models;
using SGFlooringCorp.Models.Interfaces;

namespace SGFlooringCorp.BLL
{
    public class ProductOperations
    {
        
        private IProdRepository _productRepository;

        public ProductOperations(IProdRepository myProdRepo)
        {
            _productRepository = myProdRepo;
        }

        public List<Product> ListAll()
        {
            return _productRepository.ListAll();
        }

        public string GetProductType(string productType)
        {
            var allProducts = _productRepository.ListAll();
            var product = allProducts.First(p => p.ProductType == productType);

            return product.ProductType;
        }

        public bool IsValidProductType(string productType)
        {
            var allProducts = _productRepository.ListAll();
            return allProducts.Any(p => p.ProductType == productType);
        }

        public  decimal GetCostPerSquareFoot(string productType)
        {
            var allProducts = _productRepository.ListAll();
            var product = allProducts.First(p => p.ProductType == productType);

            return product.CostPerSquareFoot;
        }

        public  decimal GetLaborCostPerSquareFoot(string productType)
        {
            var allProducts = _productRepository.ListAll();
            var product = allProducts.First(p => p.ProductType == productType);

            return product.LaborCostPerSquareFoot;
        }

        public Response<Order> GetProductCosts(OrderRequest orderRequest)
        {
            var response = new Response<Order>();
            bool isValidProductType = IsValidProductType(orderRequest.Order.ProductType);

            if(isValidProductType)
            {
                orderRequest.Order.CostPerSquareFoot = GetCostPerSquareFoot(orderRequest.Order.ProductType);
                orderRequest.Order.LaborCostPerSquareFoot = GetCostPerSquareFoot(orderRequest.Order.ProductType);
                orderRequest.Order.TotalLaborCost = CalculateLaborCost(orderRequest);
                orderRequest.Order.MaterialCost = CalculateMaterialCost(orderRequest);
                orderRequest.Order.TotalTax = CalculateTax(orderRequest);
                orderRequest.Order.Total = CalculateTotal(orderRequest);
 
                response.Success = true;
                response.Data = orderRequest.Order;
            }
            else
            {
                response.Success = false;
                response.Message = "Invalid product type entered";
            }
            return response;
        }

        public decimal CalculateLaborCost(OrderRequest orderRequest)
        {
            decimal laborCosts = orderRequest.Order.LaborCostPerSquareFoot * orderRequest.Order.Area;

            return laborCosts;
        }

        public decimal CalculateMaterialCost(OrderRequest orderRequest)
        {
            decimal materialCosts = orderRequest.Order.CostPerSquareFoot * orderRequest.Order.Area;

            return materialCosts;
        }

        public decimal CalculateTotal(OrderRequest orderRequest)
        {
             decimal total = orderRequest.Order.TotalLaborCost + orderRequest.Order.MaterialCost + orderRequest.Order.TotalTax;

            return total;
        }

        public decimal CalculateTax(OrderRequest orderRequest)
        {
             decimal totalPreTax = orderRequest.Order.TotalLaborCost + orderRequest.Order.MaterialCost;
            decimal total = totalPreTax * (orderRequest.Order.TaxRate/100);

            return total;
        }
            
        }
    }
    

