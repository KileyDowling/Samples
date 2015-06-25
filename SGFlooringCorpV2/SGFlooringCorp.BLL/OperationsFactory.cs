﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Data;
using SGFlooringCorp.Data.Mocks;

namespace SGFlooringCorp.BLL
{
    public class OperationsFactory
    {
        private static string mode = ConfigurationManager.AppSettings["Mode"];

        public static TaxOperations CreateTaxOperations()
        {
            if (mode == "Test")
                return new TaxOperations(new StateTaxRepositoryMock());
            else
            {
                //return new TaxOperations(new StateTaxReponsitory());
                throw new Exception("Prod repository not yet implemented");
            }
        }

        public static OrderOperations CreateOrderOperations()
        {
            if (mode == "Test")
                return new OrderOperations(new OrderRepository());
            else
            {
                //return new TaxOperations(new OrderRepository());
                throw new Exception("Prod repository not yet implemented");
            }
        }

        public static OrderOperations DisplayOrderOperations()
        {
            if (mode == "Test")
                return new OrderOperations(new OrderRepository());
            else
            {
                //return new TaxOperations(new OrderRepository());
                throw new Exception("Prod repository not yet implemented");
            }
        }

        public static OrderOperations RemoveOrderOperations()
        {
            if (mode == "Test")
                return new OrderOperations(new OrderRepository());
            else
            {
                //return new TaxOperations(new OrderRepository());
                throw new Exception("Prod repository not yet implemented");
            }
        }



        public static ProductOperations CreateProductOperations()
        {
            if (mode == "Test")
                return new ProductOperations(new ProdsMock());

            else
            {
                //return new ProductOperations(new ProductRepository());
                throw new Exception("Prod repository not yet implemented");
            }

        }

    }
}
