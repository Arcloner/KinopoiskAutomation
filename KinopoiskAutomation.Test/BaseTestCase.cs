using KinopoiskAutomation.Workspace.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Test
{
    [TestClass]
    public class BaseTestCase
    {
        readonly string basePage = "https://www.kinopoisk.ru/";

        protected Tester tester = new Tester();

        [TestInitialize]
        public void SetUp()
        {
            tester.GoToPage(basePage);
        }

        [TestCleanup]
        public void TearDown()
        {
            tester.FinishesWork();
        }
    }
}
