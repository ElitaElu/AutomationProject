using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationProject.src.code.control
{
   public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;

        public ControlSelenium(By locator)
        {
            this.locator = locator;
        }

        protected void findControl()
        {

            control = session.Session.Instance().GetBrowser().FindElement(locator);

        }
        public void Click()
        {
            findControl();
            control.Click();

        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                findControl();
                return control.Displayed;
            }
            catch (Exception )
            {
                return false; 
            }
        }

    }
}
