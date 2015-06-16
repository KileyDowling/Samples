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

            //SKIPPED -  Exercise9();

            //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
           // Exercise10();

            //11. Write a query to take only the first 3 elements from NumbersA.
            //Exercise11();

            //12. Get only the first 3 orders from customers in Washington.
            //Exercise12();

            //13. Skip the first 3 elements of NumbersA.
           // Exercise13();

            //14. Get all except the first two orders from customers in Washington.
           // Exercise14();

            //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
            //SKIPPED - Exercise15();

            //16. Return elements starting from the beginning of NumbersC until a number is hit that is less than its position in the array.
            //SKIPPED - Exercise16();


            //17. Return elements from NumbersC starting from the first element divisible by 3.
            //Exercise17();

            //18. Order products alphabetically by name.
            Exercise18();

            //19. Order products by UnitsInStock descending.
           // Exercise19();

            //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
            //Exercise20();

            //21. Reverse NumbersC.
//            Exercise21();

            //23. Display products by Category.
           // Exercise23();



            //32. Determine if NumbersB contains only numbers less than 9.
            //Exercise32();

           // 34. Count the number of odds in NumbersA.
          //  Exercise34();



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

        private static void Exercise14()
        {
            //14. Get all except the first two orders from customers in Washington.
            var customers = DataLoader.LoadCustomers();
            var allWAOrders = from c in customers
                from orders in c.Orders
                where c.Region == "WA"
                select new
                {
                    orderNum = orders.OrderID,
                    cust = c.CustomerID,
                    region = c.Region

                };

            var result = allWAOrders.Skip(2);

            foreach (var item in result)
            {
                Console.WriteLine("{0}, {1}, {2}", item.orderNum, item.cust, item.region);
            }
        }

        private static void Exercise15()
        {
            //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
            var numC = DataLoader.NumbersC;
            var results = from nums in numC
                select nums;
        }

        private static void Exercise16()
        {
            //16. Return elements starting from the beginning of NumbersC until a number is hit that is less than its position in the array.
        }

        private static void Exercise17()
        {
            //17. Return elements from NumbersC starting from the first element divisible by 3.
            var numC = DataLoader.NumbersC;
            var result = from num in numC
                where num % 3 == 0 && num !=0
                select num;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

        private static void Exercise18()
        {
            //18. Order products alphabetically by name.
            var products = DataLoader.LoadProducts();
            var results = products.OrderBy(p => p.ProductName);
            foreach (var result in results)
            {
                Console.WriteLine(result.ProductName);
            }

        }

        private static void Exercise19()
        {
            //19. Order products by UnitsInStock descending.
            var products = DataLoader.LoadProducts();
            var results = products.OrderByDescending(p => p.UnitsInStock);
            foreach (var result in results)
            {
                Console.WriteLine("UnitsInStock: {0}, Name: {1}", result.UnitsInStock, result.ProductName);
            }

        }

        private static void Exercise20()
        {
            //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
            var products = DataLoader.LoadProducts();
            var results2 = products.OrderByDescending(p => p.UnitPrice);
            var results = results2.OrderBy(p => p.Category);

            foreach (var item in results)
            {
             Console.WriteLine("Category: {0}, Unit Price: {1}", item.Category, item.UnitPrice);   
            }
        }

        private static void Exercise21()
        {
            //21. Reverse NumbersC.
            var numC = DataLoader.NumbersC;
            var result = numC.Reverse();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

        private static void Exercise23()
        {
            //23. Display products by Category.
            var products = DataLoader.LoadProducts();
            var results = products.OrderBy(p => p.Category);
            foreach (var result in results)
            {
                Console.WriteLine("Category: {0}, Product Name: {1}", result.Category, result.ProductName);
            }
        }

        private static void Exercise32()
        {
            //32. Determine if NumbersB contains only numbers less than 9.
            var numB = DataLoader.NumbersB;
            var result = numB.Count(i => i >= 9);
                Console.WriteLine(result==0);
        }

        private static void Exercise34()
        {
            //34. Count the number of odds in NumbersA.
            var numA = DataLoader.NumbersA;
            var result = numA.Count(i => i%2 == 1);
            Console.WriteLine(result);

        }
    }
}