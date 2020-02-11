using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Curso2_BuenasPracticas.Services.FormatTime.UTests
{
    [TestClass()]
    public class FormatTimeMountsTests
    {
        [TestMethod()]
        public void GetTimeFormatTest_SetTimeSpan_GetTimeFormatInString()
        {
            //Arrange
            TimeSpan timeDifference = new TimeSpan(30, 0, 0, 0, 0);
            string valueExpected = string.Format("{0} mes(es)", 1);
            FormatTimeMounts SUT = new FormatTimeMounts();
            //Act
            string timeFormat = SUT.GetTimeFormat(timeDifference);
            //Assert
            Assert.AreEqual(valueExpected, timeFormat);
        }
    }
}