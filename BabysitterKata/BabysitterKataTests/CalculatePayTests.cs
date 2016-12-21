using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata.Tests
{
    [TestClass()]
    public class CalculatePayTests
    {
        BabysittingJob babysittingJob = new BabysittingJob();

        [TestMethod()]
        public void OneHourPayNoBedTimeBeforeMidnightEnd()
        {
            babysittingJob.StartTime = 1700;
            babysittingJob.EndTime = 1800;
            Assert.AreEqual(12.0M, babysittingJob.CalculatePay());
        }

        [TestMethod()]
        public void OneHourPayAfterBedtimeBeforeMidnightEnd()
        {
            babysittingJob.StartTime = 1900;
            babysittingJob.EndTime = 2000;
            babysittingJob.BedTime = 1900;
            Assert.AreEqual(8.0M, babysittingJob.CalculatePay());
        }

        [TestMethod()]
        public void TwoHoursPayWithBedtimeBeforeMidnightEnd()
        {
            babysittingJob.StartTime = 1800;
            babysittingJob.EndTime = 2000;
            babysittingJob.BedTime = 1900;
            Assert.AreEqual(20.0M, babysittingJob.CalculatePay());
        }

        [TestMethod()]
        public void TwoHoursPayNoBedtimeBeforeMidnightEnd()
        {
            babysittingJob.StartTime = 1800;
            babysittingJob.EndTime = 2000;
            Assert.AreEqual(24.0M, babysittingJob.CalculatePay());
        }

        [TestMethod()]
        public void ThreeHoursPayWithBedTimeBeforeMidnightEnd()
        {
            babysittingJob.StartTime = 2000;
            babysittingJob.EndTime = 2300;
            babysittingJob.BedTime = 2200;
            Assert.AreEqual(32.0M, babysittingJob.CalculatePay());
        }

        [TestMethod()]
        public void ThreeHoursPayWithBedTimeAfterMidnightEnd()
        {
            babysittingJob.StartTime = 2200;
            babysittingJob.EndTime = 100;
            babysittingJob.BedTime = 2300;
            Assert.AreEqual(36.0M, babysittingJob.CalculatePay());
        }

        [TestMethod()]
        public void MaxTimeTest()
        {
            babysittingJob.StartTime = 1700;
            babysittingJob.EndTime = 400;
            Assert.AreEqual(148.0M, babysittingJob.CalculatePay());
        }

        [TestMethod()]
        public void MaxTimeTestWithBedtime()
        {
            babysittingJob.StartTime = 1700;
            babysittingJob.BedTime = 2100;
            babysittingJob.EndTime = 400;
            Assert.AreEqual(136.0M, babysittingJob.CalculatePay());
        }
    }
}
