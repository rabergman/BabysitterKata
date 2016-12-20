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
            babysittingJob.EndTime = 2300;
            Assert.AreEqual(2300, babysittingJob.EndTime);
        }

        [TestMethod()]
        public void VerifySettingEndTimeBeforeSettingStartTimeReturnsNull()
        {
            babysittingJob.EndTime = 2300;
            Assert.IsNull(babysittingJob.EndTime);
        }
    }
}
