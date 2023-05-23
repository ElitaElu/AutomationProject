using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationProject.src.code.session
{
    public class Session
    {
        //atributo mismo tipo
        private static Session instance = null;
        private IWebDriver browser;

             // constructor privado
        private Session()
        {
            browser = factoryBrowser.FactoryBrowser.Make("Chrome").Create();
        }

        // metodo esttico publico para su acceso global
        public static Session Instance()
        {
            if (instance == null)
            {
                instance = new Session ();
            }
            return instance;
        }


        public void CloseBrowser()
        {
            instance = null;
            browser.Quit();
        }

        public IWebDriver GetBrowser()
        {
            return browser;
        }
    }
}
