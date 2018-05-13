using KinopoiskAutomation.AOP;
using KinopoiskAutomation.Framework.Drivers;
using KinopoiskAutomation.Workspace.IoC;
using KinopoiskAutomation.Workspace.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Workspace.Users
{
    public class Tester
    {
        private Driver driver = new Driver(WebBrowsers.Chrome);

        public Tester()
        {
            DependencyResolver.Register(new PageObjectsRegistration());
        }

        public StartPageSteps AtStartPage()
        {
            return new StartPageSteps(driver.GetDriverKey());
        }

        public ResultsOfSearchSteps AtResultsOfSearchPage()
        {
            return new ResultsOfSearchSteps(driver.GetDriverKey()); 
        }

        public void GoToPage(string url)
        {
            driver.GoToUrl(url);
        }

        public void FinishesWork()
        {
            driver.CloseDriver();
        }
    }
}
