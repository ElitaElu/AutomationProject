using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.src.code.control;
using OpenQA.Selenium;
namespace AutomationProject.src.code.page
{
     public class Deletepage
    {
        public Button confirmacion = new Button(By.XPath("//form//footer//button[@type='submit']"));
    }
}
