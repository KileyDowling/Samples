using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public class EmployeeRepo
    {
        public List<Employee> GetAll()
        {
            var Employees = new List<Employee>();
            using (
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString)
                )
            {
                var cmd = new SqlCommand("SELECT FirstName, LastName,BirthDate FROM Employees", cn);
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var temp = new Employee();
                        temp.FirstName = dr.GetString(0);
                        temp.LastName = dr.GetString(1);
                        temp.DateOfBirth = dr["BirthDate"] is DBNull ? DateTime.Now : dr.GetDateTime(2);
                        Employees.Add(temp);
                    }
                }
            }
            return Employees;
        }

        public Employee GetByID(int iD)
        {
            using (
                SqlConnection cn =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
            {
                var cmd =
                    new SqlCommand(
                        "SELECT FirstName, LastName, BirthDate, EmployeeID FROM Employees WHERE EmployeeID = @ID", cn);
                cmd.Parameters.AddWithValue("@ID", iD);

                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var temp = new Employee();
                        temp.FirstName = dr.GetString(0);
                        temp.LastName = dr.GetString(1);
                        temp.DateOfBirth = dr["BirthDate"] is DBNull ? DateTime.Now : dr.GetDateTime(2);
                        temp.EmployeeID = dr.GetInt32(3);
                        return temp;
                    }
                }
            }
            return null;
        }

        public void UpdateLastName(int iD, string newName)
        {
            using (
                SqlConnection cn =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
            {
                var cmd = new SqlCommand("UPDATE Employees SET LastName=@newName WHERE EmployeeID = @iD", cn);
                cmd.Parameters.AddWithValue("@newName", newName);
                cmd.Parameters.AddWithValue("@iD", iD);

                cn.Open();
                cmd.ExecuteNonQuery();


            }
        }

        public void Delete(Employee employeeToDelete)
        {
            using (
                SqlConnection cn =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString))
            {
                var cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @iD", cn);
                cmd.Parameters.AddWithValue("@iD", employeeToDelete.EmployeeID);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Create(Employee employeeToCreate)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
            {
                var cmd = new SqlCommand("INSERT INTO Employees (FirstName, LastName) VALUES (@FirstName, @LastName)", cn);
                cmd.Parameters.AddWithValue("@FirstName", employeeToCreate.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employeeToCreate.LastName);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int GetTopEmployeeID()
        {
            using (
                SqlConnection cn =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 EmployeeID FROM Employees ORDER BY EmployeeID DESC",
                    cn);

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        {
                            var temp = dr.GetInt32(0);
                            return temp;
                        }
                    }
                }
            }
            return 999999;
        }

        public List<Order> GetOrderHist(string iD)
        {
            var Orders = new List<Order>();

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
            {
                var cmd = new SqlCommand("CustOrderHist", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CustomerID", iD);

                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var temp = new Order();
                        temp.ProductName = dr.GetString(0);
                        temp.Quantity = dr.GetInt32(1);
                        Orders.Add(temp);
                    }
                }

            }
            return Orders;
        }
    }
}