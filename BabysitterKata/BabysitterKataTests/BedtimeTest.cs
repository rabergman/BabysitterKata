using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata.Tests
{
    [TestClass()]
    public class BedTimeTests
    {
        BabysittingJob babysittingJob = new BabysittingJob();

        [TestMethod()]
        public void SettingBedTimeTest()
        {
            babysittingJob.BedTime = 2300;
            Assert.AreEqual(2300, babysittingJob.BedTime);
        }

        [TestMethod()]
        public void SettingStartTimeTestValidValue()
        {
            babysittingJob.StartTime = 2300;
            Assert.AreEqual(2300, babysittingJob.StartTime);
        }

        [TestMethod()]
        public void SettingStartTimeTestInvalidValue()
        {
            babysittingJob.StartTime = 1600;
            Assert.IsNull(babysittingJob.StartTime);
        }

        [TestMethod()]
        public void SettingEndTimeTestValidValue()
        {
            babysittingJob.StartTime = 1700;
            babysittingJob.EndTime = 2300;
            Assert.AreEqual(2300, babysittingJob.EndTime);
        }

        [TestMethod()]
        public void SettingEndTimeTestInvalidValue()
        {
            babysittingJob.StartTime = 1700;
            babysittingJob.EndTime = 1600;
            Assert.IsNull(babysittingJob.EndTime);
        }
    }
}
