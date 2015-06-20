using System;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
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
            Exercises();
         
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
                Console.WriteLine("ID: {0} \t Region: {1}", cust.CompanyName, cust.Region);
                foreach (var order in cust.Orders)
                {
                    Console.WriteLine("{0}", order.OrderID);
                }
            }
        }

        private static void Exercise4()
        {
            //4. Create a new sequence with just the names of the products.
            var products = DataLoader.LoadProducts();
            var result = products.Select(p => new
            {
                Name = p.ProductName
            });
            foreach (var item in result)
            {
                Console.WriteLine("{0}", item.Name);
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
                UnitPriceIncrease = p.UnitPrice + p.UnitPrice / quarter
            });
            foreach (var item in results)
            {
                Console.WriteLine("Product {0} -- Old cost {1:c}\t New cost {2:c}", item.ProductName, item.OriginalPrice, item.UnitPriceIncrease);
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
            var results = products.Where(p => p.UnitsInStock % 2 == 0);
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
                Console.WriteLine("{0},\t{1},\t{2}", result.ProductName, result.Category, result.Price);
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
                Console.WriteLine("Customer ID: {0}, Order ID: {1}, Total: {2}", record.CustomerID, record.OrderID, record.Total);
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
                             orderID = order.OrderID,
                             orderTot = order.Total,
                             customer = customer.CustomerID
                         };
            var firstThree = result.Take(3);
            foreach (var item in firstThree)
            {
                Console.WriteLine("Order ID: {0}, Total: {1}, Customer: {2}", item.orderID, item.orderTot, item.customer);
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
            var results = numC.TakeWhile(num => num < 6);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }

        private static void Exercise16()
        {
            //16. Return elements starting from the beginning of NumbersC 
            //until a number is hit that is less than its position in the array.

            var numC = DataLoader.NumbersC;
            var results = numC.TakeWhile((num, index) => num >= index);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            /*           var result = numC.Select((index, number) => number < index);
                        foreach (var item in result)
                        {
                            Console.WriteLine(item);
                        } */
        }

        private static void Exercise17()
        {
            //17. Return elements from NumbersC starting from the first element divisible by 3.
            var numC = DataLoader.NumbersC;
            var result = from num in numC
                         where num % 3 == 0 && num != 0
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

        private static void Exercise22()
        {
            //22. Display the elements of NumbersC grouped by their remainder when divided by 5.
            var numC = DataLoader.NumbersC;
            var results = from num in numC
                          group num by num % 5;

            foreach (var item in results)
            {
                Console.WriteLine(item.Key);

                foreach (var num in item)
                {
                    Console.WriteLine("\t{0}", num);
                }
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


        private static void Exercise24()
        {
            //24. Group customer orders by year, then by month.

        }
        public static void Exercise25()
        {
            //25. Create a list of unique product category names.   
            var products = DataLoader.LoadProducts();
            var results = from product in products
                          group product by product.Category;
            var toList = results.ToList();
            foreach (var item in toList)
            {
                Console.WriteLine(item.Key);
            }

        }

        public static void Exercise26()
        {
            //26. Get a list of unique values from NumbersA and NumbersB.
            //public static int[] NumbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //public static int[] NumbersB = { 1, 3, 5, 7, 8 };
            var numA = DataLoader.NumbersA;
            var numB = DataLoader.NumbersB;
            var result = numA.Concat(numB).ToArray();
            var checkDistinct = result.Select(x => x).Except(numA);
            var checkDistinct2 = result.Select(x => x).Except(numB);
            var joinDistrinct = checkDistinct2.Concat(checkDistinct).ToArray();
            foreach (var item in joinDistrinct)
            {
                Console.WriteLine(item);
            }
        }

        public static void Exercise27()
        {
            //27. Get a list of the shared values from NumbersA and NumbersB.
            //public static int[] NumbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //public static int[] NumbersB = { 1, 3, 5, 7, 8 };
            var result = DataLoader.NumbersA.Intersect(DataLoader.NumbersB);
            foreach (var r in result)
            {
                Console.WriteLine("{0}", r);
            }

            //intersect operator

        }


        public static void Exercise28()
        {
            //28. Get a list of values in NumbersA that are not also in NumbersB.   
            //public static int[] NumbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //public static int[] NumbersB = { 1, 3, 5, 7, 8 };

            var numA = DataLoader.NumbersA;
            var numB = DataLoader.NumbersB;
            var result = numA.Concat(numB);
            var distinct = result.Distinct().Select(x => x).Except(numB);
            foreach (var item in distinct)
            {
                Console.WriteLine(item);
            }
        }

        public static void Exercise29()
        {
            //29. Select only the first product with ProductID = 12 (not a list).
            var products = DataLoader.LoadProducts();
            var results = from product in products
                          where product.ProductID == 12
                          select product;

            foreach (var item in results)
            {
                Console.WriteLine("ProductID: {0}, Product Name: {1}", item.ProductID, item.ProductName);
            }

        }

        public static void Exercise30()
        {
            //30. Write code to check if ProductID 789 exists.
            var products = DataLoader.LoadProducts();
            var IDChecker = products.Select(p => p.ProductID);
            var results = IDChecker.Contains(782);
            var results2 = IDChecker.Contains(2);

            Console.WriteLine("Product ID #782 dExists? {0}", results);
            Console.WriteLine("Product ID #2 Exists? {0}", results2);

        }

        public static void Exercise31()
        {
            //31. Get a list of categories that have at least one product out of stock.
            var products = DataLoader.LoadProducts();
            var inStock = from product in products
                          from category in product.Category
                          where product.UnitsInStock == 0
                          group category by product.Category;

            foreach (var item in inStock)
            {
                Console.Write("{0}, ", item.Key);

            }
        }

        private static void Exercise32()
        {
            //32. Determine if NumbersB contains only numbers less than 9.
            var numB = DataLoader.NumbersB;
            var result = numB.Count(i => i >= 9);
            Console.WriteLine(result == 0);
        }

        public static void Exercise33()
        {
            //33. Get a grouped a list of products only for categories that have all of their products in stock.
            var categories = DataLoader.LoadProducts().GroupBy(p => p.Category);
            var result = categories.Where(a => a.All(p => p.UnitsInStock != 0));
            foreach (var item in result)
            {
                Console.WriteLine("{0}", item.Key);
                foreach (var category in item)
                {
                    Console.WriteLine("\t{0}, {1}", category.UnitsInStock, category.ProductName);
                }
            }



        }

        private static void Exercise34()
        {
            //34. Count the number of odds in NumbersA.
            var numA = DataLoader.NumbersA;
            var result = numA.Count(i => i % 2 == 1);
            Console.WriteLine(result);

        }

        private static void Exercise35()
        {
            //35. Display a list of CustomerIDs and only the count of their orders.
            var customers = DataLoader.LoadCustomers();
            var count = from cust in customers
                        group cust.Orders.Count() by cust.CustomerID;

            foreach (var result in count)
            {
                Console.Write("{0}", result.Key);
                foreach (var r in result)
                {
                    Console.WriteLine("\t{0}", r);
                }
            }

        }

        private static void Exercise36()
        {
            //36. Display a list of categories and the count of their products.
            var products = DataLoader.LoadProducts();
            var categoryCount = from p in products
                group p.ProductName by p.Category
                into g
                select new {Category = g.Key, ProductCount = g.Count()};
                
            foreach (var item in categoryCount)
            {
                Console.WriteLine("{0} -- {1} ", item.Category, item.ProductCount);
            }
        }

        private static void Exercises37()
        {
            //37. Display the total units in stock for each category.
            var products = DataLoader.LoadProducts();
            var groupByCategory = from product in products
                group product.UnitsInStock by product.Category
                into p
                select new {Category = p.Key, UnitsInStock = p.Sum()};

            foreach (var item in groupByCategory)
            {
                Console.WriteLine("tUnitsInStock: {1} \tCategory: {0}", item.Category, item.UnitsInStock);
            }
        }

        private static void Exercise38()
        {
            //38. Display the lowest priced product in each category.
            //group products by category, find the lowest priced product in each category
            var products = DataLoader.LoadProducts();
            var byCategory = from product in products
                group product.UnitPrice by product.Category
                into p
                select new { Category = p.Key, LowestPricedItem = p.Min()};
            foreach (var item in byCategory)
            {
                Console.WriteLine("{0}", item);
            }
        }
        
        private static void Exercise39()
        {
            //39. Display the highest priced product in each category.
            var products = DataLoader.LoadProducts();
            var highestPriced = from product in products
                group product.UnitPrice by product.Category
                into p
                select new {CategoryName = p.Key, HighestPrice = p.Max()};

            foreach (var item in highestPriced)
            {
                Console.WriteLine("{0}", item);
            }



        }

        private static void Exercise40()
        {
            //40. Show the average price of product for each category.
            var products = DataLoader.LoadProducts();
            var avgPriceByCategory = from product in products
                group product.UnitPrice by product.Category
                into p
                select new {Category = p.Key, AveragePrice = p.Average()};

            foreach (var item in avgPriceByCategory)
            {
                Console.WriteLine("Avg Price: {0:C} -- {1}", item.AveragePrice, item.Category);
            }

        }

        private static void Exercises()
        {
            //1. Find all products that are out of stock.
            Exercise1();

            //2. Find all products that are in stock and cost more than 3.00 per unit.
            Exercise2();

            //3. Find all customers in Washington, print their name then their orders. (Region == "WA")
            Exercise3();

            //4. Create a new sequence with just the names of the products.
            Exercise4();

            //5. Create a new sequence of products and unit prices where the unit prices are increased by 25%.
            Exercise5();

            //6. Create a new sequence of just product names in all upper case.
            Exercise6();

            //7. Create a new sequence with products with even numbers of units in stock.
            Exercise7();

            //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.
            Exercise8();

            //9. Make a query that returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //SKIPPED -  Exercise9();

            //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
            Exercise10();

            //11. Write a query to take only the first 3 elements from NumbersA.
            Exercise11();

            //12. Get only the first 3 orders from customers in Washington.
            Exercise12();

            //13. Skip the first 3 elements of NumbersA.
            Exercise13();

            //14. Get all except the first two orders from customers in Washington.
            Exercise14();

            //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
            Exercise15();

            //16. Return elements starting from the beginning of NumbersC until a number is hit that is less than its position in the array.
            Exercise16();


            //17. Return elements from NumbersC starting from the first element divisible by 3.
            Exercise17();

            //18. Order products alphabetically by name.
            Exercise18();

            //19. Order products by UnitsInStock descending.
            Exercise19();

            //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
            Exercise20();

            //21. Reverse NumbersC.
            Exercise21();

            //22. Display the elements of NumbersC grouped by their remainder when divided by 5.
            Exercise22();

            //23. Display products by Category.
            Exercise23();

            //24. Group customer orders by year, then by month.
            //SKIPPED -- Exercise24();


            //25. Create a list of unique product category names.
            Exercise25();

            //26. Get a list of unique values from NumbersA and NumbersB.
            Exercise26();

            //27. Get a list of the shared values from NumbersA and NumbersB.
            Exercise27();

            //28. Get a list of values in NumbersA that are not also in NumbersB.
            Exercise28();

            //29. Select only the first product with ProductID = 12 (not a list).
            Exercise29();


            //30. Write code to check if ProductID 789 exists.
            Exercise30();

            //31. Get a list of categories that have at least one product out of stock.
            Exercise31();

            //32. Determine if NumbersB contains only numbers less than 9.
            Exercise32();

            //33. Get a grouped a list of products only for categories that have all of their products in stock.
            Exercise33();

            // 34. Count the number of odds in NumbersA.
            Exercise34();

            //35. Display a list of CustomerIDs and only the count of their orders.
            Exercise35();

            //36. Display a list of categories and the count of their products.
           Exercise36();

            //37. Display the total units in stock for each category.
           Exercises37();

            //38. Display the lowest priced product in each category.
           Exercise38();

            //39. Display the highest priced product in each category.
            Exercise39();

            //40. Show the average price of product for each category.
            Exercise40();

        }
    }
}