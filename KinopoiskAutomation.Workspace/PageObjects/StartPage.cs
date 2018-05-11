using KinopoiskAutomation.Framework.PageObjects.Base;
using KinopoiskAutomation.Workspace.PageObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Workspace.PageObjects
{
    public class StartPage : BasePage, IStartPage
    {
        public StartPage(Guid DriverKey) : base(DriverKey){}

        public void ClickSignIn()
        {
            throw new NotImplementedException();
        }
    }
}
