using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationProject.src.code.control;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;


namespace AutomationProject.src.code.page
{
    public class leftSite
    {

        //;adir nuevo proyecto
        public Button addNewProjectButton = new Button(By.XPath("//button[@aria-label='Añadir proyecto']"));


        
        public Button subMenuIcon = new Button(By.XPath("//button[@aria-label='Más acciones de proyecto']"));
        public Button editButton = new Button(By.XPath("//ul[@role='menu']//li//div//div[text()='Editar proyecto']"));
       
       
        public Button deleteButton = new Button(By.Id("ProjShareMenuDel"));


    public Boolean ProjectNameIsDisplayed(String nameValue)
    {
        Label nameProject = new Label(By.XPath("(//ul[@id=\"projects_list\"]//div//a//span[text()='" + nameValue + "'])[last()]"));
        return nameProject.IsControlDisplayed();
    }

    public void ClickProjectName(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id='projects_list']//div//a//span[text()='" + nameValue + "'])[last()]"));
            nameProject.Click();
        }
    }
}
