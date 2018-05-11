﻿using KinopoiskAutomation.AOP;
using KinopoiskAutomation.Workspace.PageObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Workspace.Steps
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
