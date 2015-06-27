using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Models;
using SGFlooringCorp.Models.Interfaces;

namespace SGFlooringCorp.Data
{
    public class ProductRepository : IProdRepository
    {
        public List<Models.Product> ListAll()
        {
            List<Product> productTypes = new List<Product>();

          const string FilePath = @"DataFiles\Products.txt";
            if(File.Exists(FilePath))
            {
                var reader = File.ReadAllLines(FilePath);
                  for (int i = 1; i < reader.Length; i++)
                {
                    var columns = reader[i].Split(',');

                    var productType = new Product();
                    productType.ProductType =  columns[0];
                    productType.CostPerSquareFoot = decimal.Parse(columns[1]);
                    productType.LaborCostPerSquareFoot = decimal.Parse(columns[2]);

                    productTypes.Add(productType);
                }		    
                return productTypes;
            }
            return null;

        }


        }
    }
