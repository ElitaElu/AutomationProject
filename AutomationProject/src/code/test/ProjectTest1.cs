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

        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("elitachio266@gmail.com", "Chio0902**");

          /*  leftSite.addNewProjectButton.Click();
            addProject.projectNameTxtBox.SetText("Eliana");
           // addProject.color.Click();
            addProject.addButton.Click();
            //leftSite.ProjectNameIsDisplayed("Eliana");

            // add verificacion
           Assert.IsTrue(leftSite.ProjectNameIsDisplayed("Eliana"),"ERROR!The project was not created");*/

            leftSite.ClickProjectName("Eliana");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            editPage.projectNameEditTxtBox.SetText("Mojixupdated");
            Thread.Sleep(1000);
            editPage.saveButton.Click();
            Thread.Sleep(1000);
            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("Mojix"), "ERROR!The project was not updated");

/*
            leftSite.ClickProjectName("MojixUpdateddddd");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();

            Thread.Sleep(1000);
            session.Session.Instance().GetBrowser().SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
            // add verificacion
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!The project was not deleted");*/


        }

    }
}
