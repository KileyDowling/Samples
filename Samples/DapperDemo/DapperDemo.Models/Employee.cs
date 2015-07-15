using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        public int LocationID { get; set; }
        public int ManagerID { get; set; }
        public string Status { get; set; }
    }
}
