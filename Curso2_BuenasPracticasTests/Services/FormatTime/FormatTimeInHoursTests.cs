using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Curso2_BuenasPracticas.Services.FormatTime.UTests
{
    [TestClass()]
    public class FormatTimeInHoursTests
    {
        [TestMethod()]
        public void GetTimeFormatTest_SetTimeSpan_GetTimeFormatInString()
        {
            //Arrange
            TimeSpan timeDifference = new TimeSpan(0, 8, 0, 0, 0);
            string valueExpected = string.Format("{0} hora(s)", 8);
            FormatTimeInHours SUT = new FormatTimeInHours();
            //Act
            string timeFormat = SUT.GetTimeFormat(timeDifference);
            //Assert
            Assert.AreEqual(valueExpected, timeFormat);
        }
    }
}