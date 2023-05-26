using AutomationProject.src.code.page;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
namespace AutomationProject.src.code.test
{

    [TestClass]

    public class ProjectTest1 :TestBase
    {
        
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        MenuSection menuSection = new MenuSection();
        leftSite leftSite = new leftSite();
        addProject addProject = new addProject();
        EditPage editPage = new EditPage();
        Deletepage deletepage = new Deletepage();

        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("elitachio266@gmail.com", "Chio0902**");

           
            leftSite.addNewProjectButton.Click();
            addProject.projectNameTxtBox.SetText("Eliana");
           // addProject.color.Click();
            addProject.addButton.Click();
      
            
            // add verificacion
           Assert.IsTrue(leftSite.ProjectNameIsDisplayed("Eliana"),"ERROR!The project was not created");

            leftSite.ClickProjectName("Eliana");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            editPage.projectNameEditTxtBox.SetText("testupdate");
            Thread.Sleep(1000);
            editPage.saveButton.Click();
            Thread.Sleep(1000);

            // update verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("testupdate"), "ERROR!The project was not updated");
            

            leftSite.ClickProjectName("testupdate");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();
            

            
            Thread.Sleep(1000);
          deletepage.confirmacion.Click();
         
            Thread.Sleep(1000);
            // add verificacion
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed("testupdate"), "ERROR!The project was not deleted");
            

        }

    }
}
