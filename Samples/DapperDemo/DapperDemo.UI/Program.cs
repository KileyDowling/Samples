using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperDemo.Data;
using DapperDemo.Models;

namespace DapperDemo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** DAPPER DEMO ***\n\n");

            ShowAllEmployees();
            //ShowEmployeeUsingInlineParams();
            //ShowEmployeeUsingDynamicParams();
            //ShowOneEmployee();
            //ShowOneEmployeeWithProc();
            //InsertAndShowNewId();


            Console.ReadLine();

        }

        //private static void InsertAndShowNewId()
        //{
        //    var repo = new EmployeeRepository();
        //    var result = repo.InsertNewEmployee();
        //    Console.WriteLine("New Employee Id is {0}", result);
        //}

        //private static void ShowOneEmployeeWithProc()
        //{
        //    var repo = new EmployeeRepository();
        //    var employee = repo.GetSingleEmployeeWithProc(7);
        //    DisplayEmployee(employee);
        //}

        static void ShowAllEmployees()
        {
            var repo = new EmployeeRepository();
            var employees = repo.GetAllEmployees();
            DisplayEmployeeList(employees);
        }

        //static void ShowEmployeeUsingInlineParams()
        //{
        //    var repo = new EmployeeRepository();
        //    var employees = repo.GetEmployeeListWithInlineParam(4);
        //    DisplayEmployeeList(employees);
        //}

        //static void ShowEmployeeUsingDynamicParams()
        //{
        //    var repo = new EmployeeRepository();
        //    var employees = repo.GetEmployeeListWithDynamicParam(5);
        //    DisplayEmployeeList(employees);
        //}

        static void ShowOneEmployee()
        {
            var repo = new EmployeeRepository();
            var employee = repo.GetSingleEmployee(4);
            DisplayEmployee(employee);
        }

        private static void DisplayEmployee(Employee employee)
        {
            Console.WriteLine("ID:\t\t{0}", employee.EmpID);
            Console.WriteLine("First:\t\t{0}", employee.FirstName);
            Console.WriteLine("Last:\t\t{0}", employee.LastName);
            Console.WriteLine("Hired:\t\t{0:d}", employee.HireDate);
        }

        static void DisplayEmployeeList(List<Employee> employees)
        {
            Console.WriteLine("{0,-4} {1,-15} {2, -15} {3,-10}", "ID", "First Name", "Last Name", "Hire Date");
            foreach (var employee in employees)
            {
                Console.WriteLine("{0,-4} {1,-15} {2, -15} {3,-10:d}", employee.EmpID, employee.FirstName, employee.LastName, employee.HireDate);
            }
        }
    }
}
