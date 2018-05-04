using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exe10.Test
{
    [TestClass]
    public class UnitTest1
    {
        EmailValidator.EmailValidator testValidator;
        string Entry ="someone@somewhere.com";

        [TestInitialize]
        public void BeforeTest()
        {
            testValidator = new EmailValidator.EmailValidator(Entry);            
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(testValidator.ValidateEmail());
        }        
    }
}
