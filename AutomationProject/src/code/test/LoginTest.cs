using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationProject.src.code.page;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationProject.src.code.test
{

    [TestClass]
    public class LoginTest : TestBase
        {

            MainPage mainPage = new MainPage();
            LoginSection loginSection = new LoginSection();
            MenuSection menuSection = new MenuSection();



            [TestMethod]
            public void VerifyTheLoginIsSuccessfuly2()
            
        {
                mainPage.loginButton.Click();
                loginSection.emailTxtBox.SetText("elitachio266@gmail.com");
                loginSection.pwdTxtBox.SetText("Chio0902**");
                loginSection.loginButton.Click();
                menuSection.AbrirMenu.Click();
               

                Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(),
                "ERROR !! the login was not successfully, review credentials please");
     
        }

        }
    
}
