using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Curso2_BuenasPracticas.Services.FormatTime.UTests
{
    [TestClass()]
    public class FormatTimeInMinutesTests
    {
        [TestMethod()]
        public void GetTimeFormatTest_SetTimeSpan_GetTimeFormatInString()
        {
            //Arrange
            TimeSpan timeDifference = new TimeSpan(0, 0, 25, 0, 0);
            string valueExpected = string.Format("{0} minutos", 25);
            FormatTimeInMinutes SUT = new FormatTimeInMinutes();
            //Act
            string timeFormat = SUT.GetTimeFormat(timeDifference);
            //Assert
            Assert.AreEqual(valueExpected, timeFormat);
        }
    }
}