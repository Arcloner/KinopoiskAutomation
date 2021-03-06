﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Framework.Waiters
{
    public class DefaultWaiter
    {
        public void WaitForElementIsDisplayed(IWebElement element)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromMinutes(1);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                try
                {
                    return ele.Displayed;
                }
                catch (Exception) { throw; }
            });
            wait.Until(waiter);
        }
        public void WaitElementDisapear(IWebElement element)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromMinutes(1);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                try
                {
                    return !ele.Displayed;
                }
                catch (Exception) { return true; }
            });
            wait.Until(waiter);
        }
        public void WaitElementDisapear(IWebElement element, int delay)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromMinutes(delay);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                try
                {
                    return !ele.Displayed;
                }
                catch (Exception) { return true; }
            });
            wait.Until(waiter);
        }
        public void WaitForElementIsEnabled(IWebElement element)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromMinutes(1);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                try
                {
                    return ele.Enabled;
                }
                catch (Exception) { throw; }
            });
            wait.Until(waiter);
        }
        public void WaitForElementIsVisible(IWebElement element)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromMinutes(1);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                try
                {
                    return ele.Enabled && ele.Displayed;
                }
                catch (Exception) { throw; }
            });
            wait.Until(waiter);
        }
    }
}
