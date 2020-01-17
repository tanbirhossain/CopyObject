using System;
using CopyObject.Tests.Entity;
using CopyObject.Tests.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CopyObject.Tests
{
    [TestClass]
    public class DtoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            User userEntity = new User();
            UserVM userVM = new UserVM();
            userVM.CopyObjectFrom(userEntity);
            Assert.AreEqual(userVM.Name, userEntity.Name);
            Assert.AreEqual(userVM.DOB, userEntity.DOB);
            Assert.AreEqual(userVM.Id, userEntity.Id);
 
        }
    }
}
