using KinopoiskAutomation.Framework.AOP;
using KinopoiskAutomation.Framework.Drivers;
using KinopoiskAutomation.Framework.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Framework.Users
{
    public class Tester
    {
        private Driver driver = new Driver(WebBrowsers.Chrome);

        public StartPageSteps AtStartPage()
        {
            return new StartPageSteps(driver.GetDriverKey());
        }
    }
}
