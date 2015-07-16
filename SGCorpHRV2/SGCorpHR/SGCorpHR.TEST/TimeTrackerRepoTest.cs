using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SGCorpHR.DATA;
using SGCorpHR.Models;

namespace SGCorpHR.TEST
{
    [TestFixture]
    public class TimeTrackerRepoTest
    {
        [Test]
        public void GetAllSheetsTest()
        {
            var repo = new TimeTrackerRepository();
            List<Timesheet> timesheets = new List<Timesheet>();
            timesheets = repo.GetAllTimeSheets(6);
            Assert.AreEqual(4, timesheets.Count);
        }
    }
}
