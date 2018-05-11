using KinopoiskAutomation.Workspace.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
