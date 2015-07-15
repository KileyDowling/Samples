using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperDemo.Models;

namespace DapperDemo.Data
{
    public class EmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                return cn.Query<Employee>("SELECT * FROM Employee").ToList();
            }
        }

        public List<Employee> GetEmployeeListWithInlineParam(int empID)
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                return
                    cn.Query<Employee>("SELECT EmpID, LastName FROM Employee WHERE EmpID > @EmployeeId", new {EmployeeId = empID})
                        .ToList();
            }
        }

        public List<Employee>  GetEmployeeListWithDynamicParam(int empId)
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var  p  = new DynamicParameters();
                var date = DateTime.Parse("1/1/2000");
                p.Add("EmployeeId", empId);
                p.Add("hireDate", date);

                return
                    cn.Query<Employee>("SELECT EmpID, LastName, HireDate FROM Employee WHERE EmpID < @EmployeeId AND HireDate > @hireDate", p)
                        .ToList();
            }
        }

        public Employee GetSingleEmployee(int empId)
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var p  = new DynamicParameters();
                p.Add("EmployeeId", empId);
                return cn.Query<Employee>("SELECT * FROM Employee WHERE EmpID = @EmployeeId", p).FirstOrDefault();
            }
        }

        public Employee GetSingleEmployeeWithProc(int empId)
        {

            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("EmployeeId", empId);
                return cn.Query<Employee>("GetEmployee", p, commandType: CommandType.StoredProcedure).FirstOrDefault();

            }
        }

        public int InsertNewEmployee()
        {
            
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var P = new DynamicParameters();
                P.Add("FirstName", "Kiwi");
                P.Add("LastName", "Erin");
                P.Add("EmpId", DbType.Int32, direction: ParameterDirection.Output);

                cn.Execute("InsertEmployee", P, commandType: CommandType.StoredProcedure);

                return P.Get<int>("EmpId");
            }
        }
    }
}
