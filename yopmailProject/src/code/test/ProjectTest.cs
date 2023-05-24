using SeleniumTrining.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTrining.src.code.test
{
    [TestClass]
    public class ProjectTest : TestBase
    {

        MainPage mainPage = new MainPage();
       // LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();

        /*

        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("bootcamp2@mojix.com", "12345");

            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText("Mojix909090_rlb");
            leftSite.addButton.Click();

            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("Mojix909090_rlb"), "ERROR!The project was not created");

            leftSite.ClickProjectName("Mojix909090_rlb");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText("MojixUpdatedddd!");
            leftSite.saveButton.Click();

            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("MojixUpdatedddd!"), "ERROR!The project was not updated");


            leftSite.ClickProjectName("MojixUpdatedddd!");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();

            Thread.Sleep(1000);
            session.Session.Instance().GetBrowser().SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
            // add verificacion
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!The project was not deleted");
        }
        */
    }
}
