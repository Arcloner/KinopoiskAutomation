using KinopoiskAutomation.Framework.AOP;
using KinopoiskAutomation.Framework.PageObjects.Interfaces;
using System;

namespace KinopoiskAutomation.Framework.Steps
{
    public class StartPageSteps
    {
        IStartPage startPage;

        public StartPageSteps(Guid driverId)
        {
            startPage = DependencyResolver.For<IStartPage>(driverId);
        }
    }
}
