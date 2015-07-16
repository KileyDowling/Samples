using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGCorpHR.Models;
using Dapper;

namespace SGCorpHR.DATA
{
    public class TimeTrackerRepository
    {
        public List<Timesheet> GetAllTimeSheets(int employeeId)
        {
           using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                return
                    cn.Query<Timesheet>("SELECT * FROM TimeSheet WHERE EmpId = @empId",
                        new {empId = employeeId}).ToList();
            }
        }
    }
}
