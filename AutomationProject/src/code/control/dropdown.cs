using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationProject.src.code.control
{
 public class dropdown: ControlSelenium
    {
        public dropdown(By locator) : base(locator)
        { }

        public void FindE(string value)
        {
            findControl();
            control.Clear();
            control.SendKeys(value);
        }
    }
}
