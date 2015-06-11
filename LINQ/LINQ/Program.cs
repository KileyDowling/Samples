using System;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting;

namespace LINQ
{
    internal class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */

        private static void Main()
        {
            //1. Find all products that are out of stock.
            // Exercise1();

            //2. Find all products that are in stock and cost more than 3.00 per unit.
            // Exercise2();

            //3. Find all customers in Washington, print their name then their orders. (Region == "WA")
            //Exercise3();

            //4. Create a new sequence with just the names of the products.
           // Exercise4();

            //5. Create a new sequence of products and unit prices where the unit prices are increased by 25%.
           // Exercise5();

            //6. Create a new sequence of just product names in all upper case.
            // Exercise6();

            //7. Create a new sequence with products with even numbers of units in stock.
            //Exercise7();

            //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.
            //Exercise8();

            //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
           // Exercise10();

            //11. Write a query to take only the first 3 elements from NumbersA.
            //Exercise11();

            //12. Get only the first 3 orders from customers in Washington.
            //Exercise12();

            //13. Skip the first 3 elements of NumbersA.
           // Exercise13();

            Console.ReadLine();
        }

        private static void Exercise1()
        {
            var products = DataLoader.LoadProducts();

            var results = products.Where(p => p.UnitsInStock == 0);

            foreach (var product in results)
            {
                Console.WriteLine("{0} - {1}", product.ProductID, product.ProductName);
            }
        }

        private static void Exercise2()
        {
            //2. Find all products that are in stock and cost more than 3.00 per unit.
            var products = DataLoader.LoadProducts();
            var results = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);

            foreach (var product in results)
            {
                Console.WriteLine("Product: {0} \t # In Stock: {1} \t Price: {2:c}", product.ProductName,
                    product.UnitsInStock, product.UnitPrice);

            }
        }

        private static void Exercise3()
        {
            //3. Find all customers in Washington, print their name then their orders. (Region == "WA")

            var customers = DataLoader.LoadCustomers();
            var results = (customers.Where(c => c.Region == "WA"));

            foreach (var cust in results)
            {
                Console.WriteLine("ID: {0} \t Region: {1}", cust.CustomerID, cust.Region);
            }
        }

        private static void Exercise4()
        {
            //4. Create a new sequence with just the names of the products.
            var products = DataLoader.LoadProducts();
            var result = products.Select(p=> new
            {
                Name = p.ProductName
            });
            foreach (var item in result)
            {
                Console.WriteLine("{0}",item.Name);
            }
        }

        private static void Exercise5()
        {
            //5. Create a new sequence of products and unit prices where the unit prices are increased by 25%.
            int quarter = 4;
            var products = DataLoader.LoadProducts();
            var results = products.Select(p => new
            {
                ProductName = p.ProductName,
                OriginalPrice = p.UnitPrice,
                UnitPriceIncrease = p.UnitPrice + p.UnitPrice/quarter
            });
            foreach (var item in results)
            {
                Console.WriteLine("Product {0} -- Old cost {1:c}\t New cost {2:c}", item.ProductName, item.OriginalPrice,item.UnitPriceIncrease);
            }
        }

        private static void Exercise6()
        {
            //6. Create a new sequence of just product names in all upper case.
            var products = DataLoader.LoadProducts();

            var results = products.Select(p => new
            {
                ProductName = p.ProductName.ToUpper()
            });
            foreach (var result in results)
            {
                Console.WriteLine("{0}", result.ProductName);
            }

        }

        private static void Exercise7()
        {
            //7. Create a new sequence with products with even numbers of units in stock.
            var products = DataLoader.LoadProducts();
            var results = products.Where(p => p.UnitsInStock%2 == 0);
            foreach (var product in results)
            {
                Console.WriteLine("# in Stock: {0} \t --- \t{1}", product.UnitsInStock, product.ProductName);
            }

        }

        private static void Exercise8()
        {
            //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.
            var products = DataLoader.LoadProducts();

            var results = products.Select(p => new
            {
                ProductName = p.ProductName,
                Category = p.Category,
                Price = p.UnitPrice
            });

            foreach (var result in results)
            {
                Console.WriteLine("{0},\t{1},\t{2}",result.ProductName,result.Category,result.Price);
            }

        }

        private static void Exercise9()
        {
            //9. Make a query that returns only the pairs of numbers from both arrays 
            //such that the number from numbersB is less than the number from numbersC.
            //return pairs of numbers, where a is less than b at the individual location in the array

        }

        private static void Exercise10()
        {
//            10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.

            var customers = DataLoader.LoadCustomers();
            var result = from customer in customers
                from orders in customer.Orders
                where orders.Total < 500
                select new
                {
                    CustomerID = customer.CustomerID,
                    OrderID = orders.OrderID,
                    Total = orders.Total
                };

            foreach (var record in result)
            {
                Console.WriteLine("Customer ID: {0}, Order ID: {1}, Total: {2}", record.CustomerID,record.OrderID,record.Total);
            }


        }

        private static void Exercise11()
        {
            //11. Write a query to take only the first 3 elements from NumbersA.
            var numbersA = DataLoader.NumbersA;
            var result = numbersA.Take(3);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

    ;

        }

        private static void Exercise12()
        {
            //12. Get only the first 3 orders from customers in Washington.

            var customers = DataLoader.LoadCustomers();
            var result = from customer in customers
                from order in customer.Orders
                where customer.Region == "WA"
                select new
                {
                    order = order.OrderID,
                    orderTot = order.Total,
                    customer = customer.CustomerID
                };
            var firstThree = result.Take(3);
            foreach (var item in firstThree)
            {
                Console.WriteLine("Order ID: {0}, Total: {1}, Customer: {2}",item.order,item.orderTot ,item.customer);
            }

        }

        private static void Exercise13()
        {
            //13. Skip the first 3 elements of NumbersA.
            var numbersA = DataLoader.NumbersA;
            var result = numbersA.Skip(3);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}