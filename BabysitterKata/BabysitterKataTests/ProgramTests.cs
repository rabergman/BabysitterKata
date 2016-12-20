using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabysitterKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        BabysittingJob babysittingJob = new BabysittingJob();

        [TestMethod()]
        public void VerifySettingStartTimeTest()
        {
            babysittingJob.StartTime = 1700;

            Assert.AreEqual(1700, babysittingJob.StartTime);
        }

        [TestMethod()]
        public void VerifyInvalidStartTimeReturnsNull()
        {
            babysittingJob.StartTime = 1500;

            Assert.IsNull(babysittingJob.StartTime);
        }

        [TestMethod()]
        public void VerifyStartTimeAfterMidnightIsValid()
        {
            babysittingJob.StartTime = 100;

            Assert.AreEqual(100, babysittingJob.StartTime);
        }
    }
}