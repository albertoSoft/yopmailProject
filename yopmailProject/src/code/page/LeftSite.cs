using OpenQA.Selenium;
using SeleniumTrining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTrining.src.code.page
{
    public class LeftSite
    {
        
        public Button newEmailButton = new Button(By.Id("newmail"));
        public Button refreshInboxMenuButton = new Button(By.Id("refresh"));

        /*
        public TextBox projectNameTxtBox = new TextBox(By.Id("NewProjNameInput"));
        public Button addButton = new Button(By.Id("NewProjNameButton"));

        public Button subMenuIcon = new Button(By.XPath("//div[contains(@style,'block')]/img"));
        public Button editButton = new Button(By.XPath("//ul[contains(@style,'block')]//a[text()='Edit']"));
        public TextBox projectNameEditTxtBox = new TextBox(By.XPath("//td/div/input[@id='ItemEditTextbox']"));
        public Button saveButton = new Button(By.XPath("//td/div/img[@id='ItemEditSubmit']"));

        public Button deleteButton = new Button(By.Id("ProjShareMenuDel"));
        */
        public Boolean EmptyInboxIsDisplayed()
        {
            Label emptyInboxLabel = new Label(By.Id("message"));
            return emptyInboxLabel.IsControlDisplayed();
        }
        /*
        public void ClickProjectName(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='" + nameValue + "'])[last()]"));
            nameProject.Click();
        }*/
    }
}
