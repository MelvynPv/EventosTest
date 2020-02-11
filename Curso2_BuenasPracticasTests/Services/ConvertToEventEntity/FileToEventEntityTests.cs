using Microsoft.VisualStudio.TestTools.UnitTesting;
using Curso2_BuenasPracticas.Services.ConvertToEntity;
using System;
using System.Collections.Generic;
using System.Text;
using Curso2_BuenasPracticas.Services.Interfaces;
using Moq;
using Curso2_BuenasPracticas.Models;

namespace Curso2_BuenasPracticas.Services.ConvertToEntity.UTests
{
    [TestClass()]
    public class FileToEventEntityTests
    {
        [TestMethod()]
        [DataRow("Navidad,25/12/2020",1)]
        [DataRow("",0)]
        [DataRow("Navidad2020,25/12/2020\nNavidad2019,25/12/2020 12:00:00",2)]
        public void ConvertToEventEntityTest_ExistElementsInFile_GetListWithElementsRelatedInFile(string fileResultContent, int valueExpected)
        {
            //Arrange
            Mock<IFileReaderEvent> DOCFileReaderEvent = new Mock<IFileReaderEvent>();
            DOCFileReaderEvent.Setup(m => m.ReadFile(It.IsAny<string>())).Returns(fileResultContent);
            FileToEventEntity SUT = new FileToEventEntity(DOCFileReaderEvent.Object, ',', '\n');
            //Act
            List<EventEntity> eventEntities = SUT.ConvertToEventEntity();
            //Assert
            Assert.AreEqual(valueExpected, eventEntities.Count);
        }

        [TestMethod()]
        public void ConvertToEventEntityTest_DOCIsNull_GetArgumentNullException() 
        {
            //Arrange
            string valueExpected = "Value cannot be null. (Parameter 'fileReaderEvent')";
            //Act
            //Assert
            var error = Assert.ThrowsException<ArgumentNullException>(() => new FileToEventEntity(null, ',', '\n'));
            Assert.AreEqual(valueExpected, error.Message);
        }
    }
}