using System;
using CopyObject.Tests.Entity;
using CopyObject.Tests.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyObject;

namespace CopyObject.Tests
{
    [TestClass]
    public class DtoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            User userEntity = new User() { Id =1, Name= "Ovi", DOB=DateTime.UtcNow};

            //Act
            UserVM userVM = new UserVM();
            userVM.CopyObjectFrom(userEntity);

            //Assert
            Assert.AreEqual(userVM.Name, userEntity.Name);
            Assert.AreEqual(userVM.DOB, userEntity.DOB);
            Assert.AreEqual(userVM.Id, userEntity.Id);
 
        }
    }
}




