using Microsoft.VisualStudio.TestTools.UnitTesting;
using Curso2_BuenasPracticas.Factorys;
using System;
using System.Collections.Generic;
using System.Text;
using Curso2_BuenasPracticas.Services;
using Curso2_BuenasPracticas.Services.FormatMessage;
using Curso2_BuenasPracticas.Utils;
using Curso2_BuenasPracticas.Services.Interfaces;
using Curso2_BuenasPracticas.Services.FormatTime;
using Curso2_BuenasPracticas.Services.ConvertToEntity.Interfaces;
using Curso2_BuenasPracticas.Services.ConvertToEntity;

namespace Curso2_BuenasPracticas.Factorys.UTests
{
    [TestClass()]
    public class ServicesFactoryTests
    {
        [TestMethod()]
        [DataRow(true)]
        [DataRow(false)]
        public void GetFormatMessageTest_SetTypeMessage_GetInstanceEspecific(bool valuePass)
        {
            //Arrange
            ServicesFactory SUT = new ServicesFactory();
            //Act
            IMessageFormat instance = SUT.GetFormatMessage(valuePass);
            //Assert
            if (valuePass)
            {
                Assert.IsTrue(instance is FormatPass);
            }
            else
            {
                Assert.IsTrue(instance is FormatFuture);
            }
        }

        [TestMethod()]
        [DataRow(TimeFormat.Dias)]
        [DataRow(TimeFormat.Horas)]
        [DataRow(TimeFormat.Meses)]
        [DataRow(TimeFormat.Minutos)]
        public void GetTimeFormatTest_SetEnumType_GetInstanceEspecific(TimeFormat timeFormat)
        {
            //Arrange
            ServicesFactory SUT = new ServicesFactory();
            //Act
            ITimeFormat instance = SUT.GetTimeFormat(timeFormat);
            //Assert
            switch (timeFormat)
            {
                case TimeFormat.Minutos:
                    Assert.IsTrue(instance is FormatTimeInMinutes);
                    break;
                case TimeFormat.Horas:
                    Assert.IsTrue(instance is FormatTimeInHours);
                    break;
                case TimeFormat.Dias:
                    Assert.IsTrue(instance is FormatTimeDays);
                    break;
                case TimeFormat.Meses:
                    Assert.IsTrue(instance is FormatTimeMounts);
                    break;
            }
        }

        [TestMethod()]
        public void GetTimeFormatTest_SetEnumTypeIncorrect_GetArgumentException()
        {
            //Arrange
            string valueExpected = "No se encentro la instancia del formato del mensaje";
            ServicesFactory SUT = new ServicesFactory();
            //Act
            var error = Assert.ThrowsException<ArgumentException>(() => SUT.GetTimeFormat((TimeFormat)10));
            //Assert
            Assert.AreEqual(valueExpected,error.Message);
        }

        [TestMethod()]
        public void GetConvertTest_SetValueFromInstance_GetInstanceEspecific()
        {
            //Arrange
            ServicesFactory SUT = new ServicesFactory();
            //Act
            IConvertToEventEntity instance = SUT.GetConvert("file");
            //Assert
            Assert.IsTrue(instance is FileToEventEntity);
        }

        [TestMethod()]
        public void GetConvertTest_SetValueInExist_GetNull()
        {
            //Arrange
            ServicesFactory SUT = new ServicesFactory();
            //Act
            IConvertToEventEntity instance = SUT.GetConvert("valueInexist");
            //Assert
            Assert.IsNull(instance);
        }
    }
}