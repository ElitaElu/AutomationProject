using AutomationProject.src.code.control;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.src.code.page
{
    class addProject
    {

        public TextBox projectNameTxtBox = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button color = new Button(By.XPath("//button[@aria-labelledby='edit_project_modal_field_color_label']"));
      //  public dropdown editColor = new dropdown((By.Id("dropdown-select-0-popup")));
        public Button addButton = new Button(By.XPath("//button[@type='submit']"));
   


    }
}
