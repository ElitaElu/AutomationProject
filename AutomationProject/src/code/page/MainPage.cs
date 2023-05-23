using AutomationProject.src.code.control;
using OpenQA.Selenium;

namespace AutomationProject.src.code.page
{
    public class MainPage
    {
        
        public Button loginButton = new Button(By.XPath("//ul[@class='hGJuHEzyrDQU5nwls2PW']//li//a[@href='/auth/login']"));

    }
}
