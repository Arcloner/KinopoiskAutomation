using KinopoiskAutomation.Framework.Drivers;
using KinopoiskAutomation.Framework.PageObjects.Base;
using KinopoiskAutomation.Framework.PageObjects.ElementActions;
using KinopoiskAutomation.Framework.PageObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Framework.PageObjects
{
    public class StartPage : BasePage, IStartPage
    {
        public StartPage(Guid DriverKey) : base(DriverKey)
        {
        }

        public void ClickSignIn()
        {
            throw new NotImplementedException();
        }
    }
}
