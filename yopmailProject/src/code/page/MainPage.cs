using OpenQA.Selenium;
using SeleniumTrining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTrining.src.code.page
{
    public class MainPage
    {
       public Button checkEmailButton= new Button(By.CssSelector("button[title='Revisa el correo @yopmail.com']"));
       public TextBox temporalEmailTextBox = new TextBox(By.Id("login"));

    }
}
