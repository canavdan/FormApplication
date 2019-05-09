using System;
using FormApplication.DAL.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormApplication.DAL.Tests.EntityFrameworkTest
{
    [TestClass]
    public class EfUserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
                EfUserDal userDal = new EfUserDal();
                var result = userDal.GetList();

                Assert.AreEqual(2, result.Count);
            
        }
    }
}
