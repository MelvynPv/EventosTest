using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Curso2_BuenasPracticas.Services.FormatMessage.UTests
{
    [TestClass()]
    public class FormatPassTests
    {
        [TestMethod()]
        public void CreateMessageTest_SetEventAndTimeFormat_GetValueMessage()
        {
            //Arrange
            IEventEntity @event = new EventEntity()
            {
                DateStart = new DateTime(),
                Title = "Evento1"
            };
            string secondValue = "2 horas";
            string valueExpected = string.Format("{0} ocurrió hace {1}", @event.Title, secondValue);
            Mock<ITimeFormat> DOC_TimeFormat = new Mock<ITimeFormat>();
            DOC_TimeFormat.Setup(m => m.GetTimeFormat(It.IsAny<TimeSpan>())).Returns(secondValue);
            FormatPass SUT = new FormatPass();
            //Act
            string message = SUT.CreateMessage(@event, DOC_TimeFormat.Object);
            //Assert
            Assert.AreEqual(valueExpected, message);
        }
    }
}