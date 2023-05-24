using OpenQA.Selenium;
using SeleniumTrining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTrining.src.code.page
{
    public class InboxHeaderSection
    {
        //public Label emailInboxLabel = new Label(By.XPath("//div[@class='bname' and contains(text(),'larala@yopmail.com')]"));

        public Boolean EmailNameIsDisplayed(String EmailNameValue)
        {
            Label emailInboxLabel = new Label(By.XPath("//div[@class='bname' and contains(text(),'" + EmailNameValue.ToLower() + "@yopmail.com')]"));
            return emailInboxLabel.IsControlDisplayed();
        }
    }
}
