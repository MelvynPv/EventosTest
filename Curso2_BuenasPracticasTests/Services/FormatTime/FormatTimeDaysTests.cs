using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Curso2_BuenasPracticas.Services.FormatTime.UTests
{
    [TestClass()]
    public class FormatTimeDaysTests
    {
        [TestMethod()]
        public void GetTimeFormatTest_SetTimeSpan_GetTimeFormatInString()
        {
            //Arrange
            TimeSpan timeDifference = new TimeSpan(5, 0, 0, 0, 0);
            string valueExpected = string.Format("{0} Dia(s)", 5);
            FormatTimeDays SUT = new FormatTimeDays();
            //Act
            string timeFormat = SUT.GetTimeFormat(timeDifference);
            //Assert
            Assert.AreEqual(valueExpected, timeFormat);
        }
    }
}