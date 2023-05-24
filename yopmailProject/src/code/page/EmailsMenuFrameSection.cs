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
    public class EmailsMenuFrameSection
    {
        public Button? openOneMailButton=null;

        public void ChangeToThisFrame()
        {
            Session.Instance().GetBrowser().SwitchTo().Frame("ifinbox");
        }
        public void BackToParentFrame()
        {
            Session.Instance().GetBrowser().SwitchTo().ParentFrame();
        }
        public void SetOpenOneMailButton(string mail) 
        {
            this.openOneMailButton = new Button(By.XPath("((//button[@class='lm']/div/span[last()])[text()='"+mail.ToLower()+"@yopmail.com'])[1]"));
        }
    }
}
