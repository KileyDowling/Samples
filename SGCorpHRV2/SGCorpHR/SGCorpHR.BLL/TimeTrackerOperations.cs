using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGCorpHR.DATA;
using SGCorpHR.Models;

namespace SGCorpHR.BLL
{
    public class TimeTrackerOperations
    {
        public Response<List<Timesheet>> GetAllTimesheets(int empId)
        {
            TimeTrackerRepository repo = new TimeTrackerRepository();
            Response<List<Timesheet>> response = new Response<List<Timesheet>>();
            List<Timesheet> listOfTimesheets = repo.GetAllTimeSheets(empId);

            try
            {
                if (listOfTimesheets.Count > 0)
                {
                    response.Success = true;
                    response.Data = listOfTimesheets;
                }
                else
                {
                    response.Success = false;
                    response.Message = "There were no timesheets found for that employee";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
