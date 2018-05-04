using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe10.Test
{
    [TestClass]
    public class UnitTest2
    {
        EmailValidator.EmailValidator emailValidator;

        string[] GoodEntryArray = { "someone@somewhere.com", "someone@somewhere.co.uk", "someone+tag@somewhere.net", "futureTLD@somewhere.fooo" };

        string[] BadEntryArray = { "fdsa", "fdsa@", "fdsa@fdsa", "fdsa@fdsa." };

        [TestInitialize]
        public void BeforeTest()
        {
            emailValidator = new EmailValidator.EmailValidator(GoodEntryArray[0]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(emailValidator.ValidateEmail());

            foreach (string entry in GoodEntryArray)
            {
                Assert.IsTrue(emailValidator.ValidateEmail(entry));
            }

            foreach (string entry in BadEntryArray)
            {
                Assert.IsFalse(emailValidator.ValidateEmail(entry));
            }
        }


    }
}
