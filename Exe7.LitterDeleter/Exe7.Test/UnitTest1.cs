using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exe7.LitterDeleter;

namespace Exe7.Test
{
    [TestClass]
    public class UnitTest1
    {
        Parser testParser;

        [TestInitialize]
        public void BeforeTest()
        {
            testParser = new Parser( "<div>");
        }

        [TestMethod]
        public void TestMethod1()
        {            
            Assert.IsTrue("<>" == testParser.DeleteLitters("<", ">"));
        }
    }
}
