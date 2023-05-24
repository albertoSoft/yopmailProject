using SeleniumTrining.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yopmailProject.src.code.page;

namespace SeleniumTrining.src.code.test
{
    [TestClass]
    public class OpenInboxTest : TestBase
    {
        string fakeMailName = "laralaQA33";
        string subject = "hi2";
        string mailContent= "A B automation boot 2.0";

        MainPage mainPage = new MainPage();
        InboxHeaderSection inboxHeaderSection = new InboxHeaderSection();
        LeftSite leftSite = new LeftSite();
        IframeMail iframeMailSection = new IframeMail();
        EmailsMenuFrameSection emailsMenuFrameSection = new EmailsMenuFrameSection();


        [TestMethod]
        public void VerifyTheOpenInboxIsSuccessfuly()
        {
            mainPage.temporalEmailTextBox.SetText(fakeMailName);
            mainPage.checkEmailButton.Click();
            
            Assert.IsTrue(inboxHeaderSection.EmailNameIsDisplayed(fakeMailName),
               "ERROR !! the inbox mail was not successfully, review email name");

            leftSite.newEmailButton.Click();

            iframeMailSection.ChangeToThisFrame();
            iframeMailSection.IsNewMailLabelDisplayed();

            iframeMailSection.sendToTextBox.SetText(fakeMailName + "@yopmail.com");
            iframeMailSection.subjectTextBox.SetText(subject);
            iframeMailSection.bodyMaiTextBox.SetText(mailContent);
            iframeMailSection.senMailButton.Click();

            Assert.IsTrue(iframeMailSection.IsNewMailLabelDisplayed(), "ERROR !! sent message element  no visible");
            //Assert.IsTrue(iframeMailSection.SentMailConfirmationContainsText("Tu mensage ha sido enviado"), "ERROR !! sent message text is no visible");

            iframeMailSection.BackToParentFrame();

            leftSite.refreshInboxMenuButton.Click();

            emailsMenuFrameSection.ChangeToThisFrame();
            emailsMenuFrameSection.SetOpenOneMailButton(fakeMailName);
            emailsMenuFrameSection.openOneMailButton.Click();
            emailsMenuFrameSection.BackToParentFrame();

            iframeMailSection.ChangeToThisFrame();
            Assert.IsTrue(iframeMailSection.IsSubjectLabelDisplayed(subject), "ERROR !! subject mail no visible");
            Assert.IsTrue(iframeMailSection.IsSenderMailLabelDisplayed(fakeMailName), "ERROR !! mail sender no visible");
            Assert.IsTrue(iframeMailSection.IsBodyMailDisplayed(mailContent), "ERROR !! mail body no visible");
        }

    }
}
