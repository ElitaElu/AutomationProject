using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace AutomationProject.src.code.control
{
    public class TextBox: ControlSelenium
    {
        public TextBox(By locator) : base(locator) 
        { }
        public void SetText(string value)
        {
            findControl();
            control.Clear();
            control.SendKeys(value);
        }
    }
}
