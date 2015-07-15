using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Data;

namespace Northwind.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new EmployeeRepo();
            var employeeList = new List<Employee>();
            var employeenum = _repo.GetByID(1);

            employeeList = _repo.GetAll();

            Console.WriteLine("Order History  SPROC test!");

            var orderhistTest = _repo.GetOrderHist("ROMEY");

            foreach (var order in orderhistTest)
            {
                Console.WriteLine("{0} {1}", order.ProductName, order.Quantity);
            }
            Console.WriteLine("\nSPROC completed successfully!");
            Console.ReadLine();
            Console.Clear();

            foreach (var employee in employeeList)
            {
                Console.WriteLine("{0} {1} {2}", employee.FirstName,employee.LastName,  employee.DateOfBirth);
            }

            Console.WriteLine("Get completed!");

            Console.ReadLine();

            Console.WriteLine("\n {0} {1} {2}", employeenum.FirstName, employeenum.LastName, employeenum.DateOfBirth);
            Console.WriteLine("GetByID Completed!");

            Console.ReadLine();

            _repo.UpdateLastName(1, "Smith");
            Console.WriteLine("Update to LastName Completed!");

            var employeenumTwo = _repo.GetByID(1);

            Console.WriteLine("\n {0} {1} {2}", employeenumTwo.FirstName, employeenumTwo.LastName, employeenumTwo.DateOfBirth);

            _repo.UpdateLastName(1, "James");
            Console.ReadLine();

            _repo.Create(new Employee() {DateOfBirth = new DateTime(01/01/01), LastName =  "Thorton", FirstName = "BillyBob"});
            var employeenumThree = _repo.GetByID(_repo.GetTopEmployeeID());
            var empthreenum = employeenumThree.EmployeeID;
            Console.WriteLine("Employee being created!");
            Console.WriteLine("\n {0} {1} {2}", employeenumThree.FirstName, employeenumThree.LastName, employeenumThree.DateOfBirth);
            Console.WriteLine("Employee Created!");
            Console.ReadLine();
            Console.WriteLine("Employee being deleted!");
            _repo.Delete(employeenumThree);
            Console.WriteLine("Employee Deleted!");

            try
            {
                var employeeFailToGet = _repo.GetByID(empthreenum);
                Console.WriteLine("\n {0}, {1}, {2}", employeeFailToGet.FirstName, employeeFailToGet.LastName, employeeFailToGet.DateOfBirth);
                
                Console.ReadLine();
            }
            catch (Exception)
            { 
                Console.WriteLine("Created Employee Deleted!");
                Console.ReadLine();
                Console.WriteLine("All tests success! CRUD functional!");
            }

            Console.ReadLine();
        }
    }
}
