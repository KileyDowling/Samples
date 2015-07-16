using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetUSACustomers();
            AddRegion();
            Console.ReadLine();
        }

        private static void AddRegion()
        {
            using (var context = new NorthwindEntities())
            {
                Region newRegion = new Region();
                Console.WriteLine("Enter a new region: ");
                newRegion.RegionDescription =  Console.ReadLine();

                context.Regions.Add(newRegion);
                context.SaveChanges();
            }
        }

        private static void GetUSACustomers()
        {
            using (var context = new NorthwindEntities())
            {
                var usaCustomers = context.Customers.Where(c => c.Country == "USA");

                foreach (var customer in usaCustomers)
                {
                    Console.WriteLine("{0, -35} {1} {2}", customer.CompanyName, customer.Phone, customer.Country);
                }     
            }
        }
    }
}
