using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCorpHR.Models
{
    public class TimeTrackerSummary
    {
        public int EmpId { get; set; }
        public int TimesheetId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalHoursWorked { get; set; }
        public DateTime HireDate { get; set; }
    }
}
