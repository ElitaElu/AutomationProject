using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;


namespace AutomationProject.src.code.test
{
   public class 
        TestBase
    {
        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("https://todoist.com/");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();
        }

     
    }
}
