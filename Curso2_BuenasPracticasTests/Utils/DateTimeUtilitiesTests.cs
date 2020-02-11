using Microsoft.VisualStudio.TestTools.UnitTesting;
using Curso2_BuenasPracticas.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso2_BuenasPracticas.Utils.UTests
{
    [TestClass()]
    public class DateTimeUtilitiesTests
    {
        [TestMethod()]
        [DataRow("25/12/2020 12:00:00", "25/12/2020 12:10:00")]//minutos
        [DataRow("25/12/2020 12:00:00", "25/12/2020 22:00:00")]//hora
        [DataRow("25/12/2020", "26/12/2020")]//días
        [DataRow("25/12/2020", "15/11/2019")]//mes
        public void GetTimeEnumTest_SetDateToComparer_GetEnumWathDeterminedTimeDifference(string dateEvent, string dateActual)
        {
            //Arrange
            DateTime eventDate = DateTime.Parse(dateEvent);
            DateTime actualDate = DateTime.Parse(dateActual);
            var time = eventDate.Subtract(actualDate);
            //Act
            TimeFormat timeFormat = DateTimeUtilities.GetTimeEnum(eventDate, actualDate);
            //Assert

            if (Math.Abs(time.TotalMinutes) < 60)
            {
                Assert.IsTrue(timeFormat == TimeFormat.Minutos);
            }
            else if (Math.Abs(time.TotalHours) < 24)
            {
                Assert.IsTrue(timeFormat == TimeFormat.Horas);
            }
            else if (Math.Abs(time.TotalDays) < 30)
            {
                Assert.IsTrue(timeFormat == TimeFormat.Dias);
            }
            else
            {
                Assert.IsTrue(timeFormat == TimeFormat.Meses);
            }
        }

        [TestMethod()]
        [DataRow("25/12/2020 12:00:00", "31/12/2020 12:00:00")]//anterior
        [DataRow("25/12/2020 12:00:00", "5/12/2020 12:00:00")]//posterior
        public void DateIsPreviousToTodayTest_SetDateToComparer_GetBoolThatsIndicateToDateStartIsPresviousToDateActual(string dateEvent, string dateActual)
        {
            //Arrange
            DateTime eventDate = DateTime.Parse(dateEvent);
            DateTime actualDate = DateTime.Parse(dateActual);
            bool valueExpected = eventDate.CompareTo(actualDate) < 0;
            //Act
            bool isPrevious = DateTimeUtilities.DateIsPreviousToToday(eventDate, actualDate);
            //Assert
            Assert.AreEqual(isPrevious, valueExpected);
        }

        [TestMethod()]
        public void GetTimeDifferencDateToDateActualTest_SetDateToComparer_GetDifferenceTimeBetweenDates()
        {
            //Arrange
            DateTime eventDate = new DateTime(2020,1,20,0,0,0);
            DateTime actualDate = new DateTime(2020, 1, 15,0,0,0);
            //Act
            TimeSpan timeDifference = DateTimeUtilities.GetTimeDifferencDateToDateActual(eventDate, actualDate);
            //Assert
            Assert.AreEqual(5, timeDifference.TotalDays);
        }
    }
}