using OpenQA.Selenium;
using AutomationProject.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.src.code.test
{
    public class MenuSection
    {
      public Button AbrirMenu=new Button (By.XPath("//img[@src=\"https://dcff1xvirvpfp.cloudfront.net/a4d5cc9e53584fd886b545b15f791888_big.jpg\"]"));
      public Button logoutButton = new Button(By.XPath("//button[@role='menuitem']//span[@class='user_menu_label' and text()='Cerrar sesión']"));
    }
}