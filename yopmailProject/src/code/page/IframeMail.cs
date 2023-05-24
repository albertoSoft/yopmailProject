using OpenQA.Selenium;
using SeleniumTrining.src.code.control;
using SeleniumTrining.src.code.session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yopmailProject.src.code.page
{
    public class IframeMail
    {
        
        public TextBox sendToTextBox = new TextBox(By.Id("msgto"));
        public TextBox subjectTextBox = new TextBox(By.Id("msgsubject"));
        public TextBox bodyMaiTextBox = new TextBox(By.Id("msgbody"));
        public Button senMailButton = new Button(By.Id("msgsend"));
        protected Label sentMailConfirmation = new Label(By.Id("msgpopmsg"));



        public void ChangeToThisFrame()
        {
            Session.Instance().GetBrowser().SwitchTo().Frame("ifmail");
        }
        public void BackToParentFrame()
        {
            Session.Instance().GetBrowser().SwitchTo().ParentFrame();
        }
        public Boolean IsNewMailLabelDisplayed()
        {
            Label newMailLabel = new Label(By.XPath("//div[contains(text(),'Mensaje nuevo')]"));
            return newMailLabel.IsControlDisplayed();
        }

        public Boolean IsSentMailConfirmationDisplayed()
        {
            
            return sentMailConfirmation.IsControlDisplayed();
        }

        public Boolean SentMailConfirmationContainsText(string text)
        {
            return sentMailConfirmation.ContainsText(text);
        }


        //****** check mail
        public Boolean IsSubjectLabelDisplayed(string title)
        {
            Label subjectLabel = new Label(By.XPath("//div[contains(text(),'"+title+"')]"));
            return subjectLabel.IsControlDisplayed();
        }
        public Boolean IsSenderMailLabelDisplayed(string mail)
        {
            Label senderMailLabel = new Label(By.XPath("//span[contains(text(),'<"+mail.ToLower()+"@yopmail.com>')]"));
            return senderMailLabel.IsControlDisplayed();
        }
        public Boolean IsBodyMailDisplayed(string body)
        {
            Label bodyMailLabel = new Label(By.XPath("//div[contains(text(),'"+body+"')]"));
            return bodyMailLabel.IsControlDisplayed();
        }
    }
}
