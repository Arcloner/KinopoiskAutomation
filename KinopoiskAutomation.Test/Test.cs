using KinopoiskAutomation.Framework.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Test
{
    [TestClass]
    public class Test
    {
        Tester tester = new Tester();

        [TestMethod]
        public void DoTest()
        {
            tester.AtStartPage();
        }
    }
}
