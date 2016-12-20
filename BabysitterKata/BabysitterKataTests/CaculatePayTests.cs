using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata.Tests
{
    [TestClass()]
    public class CaculatePayTests
    {
        BabysittingJob babysittingJob = new BabysittingJob();

        [TestMethod()]
        public void VerifyCaculatingOneHourPayNoBedTimeBeforeMidnight()
        {
            babysittingJob.StartTime = 1700;
            babysittingJob.EndTime = 1800;
            Assert.AreEqual(12.0M, babysittingJob.CalculatePay());
        }

        [TestMethod()]
        public void VerifyCaculatingOneHourPayAfterBedtimeBeforeMidnight()
        {
            babysittingJob.StartTime = 1900;
            babysittingJob.EndTime = 2000;
            babysittingJob.BedTime = 1900;
            Assert.AreEqual(8.0M, babysittingJob.CalculatePay());
        }

        [TestMethod()]
        public void VerifyCaculatingTwoHoursPayWithBedtimeBeforeMidnight()
        {
            babysittingJob.StartTime = 1800;
            babysittingJob.EndTime = 2000;
            babysittingJob.BedTime = 1900;
            Assert.AreEqual(20.0M, babysittingJob.CalculatePay());
        }

    }
}
