using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.src.code.control;
using OpenQA.Selenium;

namespace AutomationProject.src.code.page
{
    public class EditPage
    {
        public TextBox projectNameEditTxtBox = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button saveButton = new Button(By.XPath("//button[@type='submit']"));
    }
}
