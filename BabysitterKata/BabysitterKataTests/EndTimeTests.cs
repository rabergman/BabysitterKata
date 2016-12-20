using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata.Tests
{
    [TestClass()]
    public class EndTimeTests
    {
        BabysittingJob babysittingJob = new BabysittingJob();

        [TestMethod()]
        public void VerifySettingEndTimeTest()
        {
            babysittingJob.StartTime = 1700;
            babysittingJob.EndTime = 2300;
            Assert.AreEqual(2300, babysittingJob.EndTime);
        }

        [TestMethod()]
        public void VerifySettingEndTimeBeforeSettingStartTimeReturnsNull()
        {
            babysittingJob.EndTime = 2300;
            Assert.IsNull(babysittingJob.EndTime);
        }

        [TestMethod()]
        public void VerifySettingEndTimeToAnInvalidTimeReturnsNull()
        {
            babysittingJob.StartTime = 1700;
            babysittingJob.EndTime = 500;
            Assert.IsNull(babysittingJob.EndTime);
        }

        [TestMethod()]
        public void VerifySettingEndTimeToATimeBeforeStartTimeReturnsNull()
        {
            babysittingJob.StartTime = 1900;
            babysittingJob.EndTime = 1800;
            Assert.IsNull(babysittingJob.EndTime);
        }
    }
}
