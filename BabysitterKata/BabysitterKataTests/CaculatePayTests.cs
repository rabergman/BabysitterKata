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
            Assert.AreEqual(12.0, babysittingJob.CalculatePay());
        }
    }
}
