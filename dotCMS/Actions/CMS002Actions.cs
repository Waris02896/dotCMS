using dotCMS.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dotCMS.Actions
{
    public class CMS002Actions
    {
        CMS002Locators locator = new CMS002Locators();
        BaseFunctions function = new BaseFunctions();

        public void OpenMenu()
        {
            Thread.Sleep(5000);
            function.ElementIsVisible(locator.WelcomeHeadingLocator, 10);
            function.clickElementByXPath(locator.MenuLocator, 20, 250);

        }

        public void ContentForm()
        {
            Thread.Sleep(3000);
            function.clickElementByXPath(locator.ContentLocator, 20, 250);
            function.clickElementByLinkText(locator.SearchButton, 10, 250);
        }

        public void InputInPersonaFilter()
        {
            function.ElementIsVisible(locator.IframeTagLocator, 10);
            function.SwitchToIframe();
            function.ElementIsVisible(locator.AddPersonaLocator, 20);
            function.ControlAll(locator.FilterLocator, 10, 250);
            function.Backspace(locator.FilterLocator, 10, 250);
            function.InputElementById(locator.Filter, "Persona", 10, 250);
            function.PressEnter(locator.FilterLocator, 10, 250);
            Thread.Sleep(5000);
        }
    }
}
