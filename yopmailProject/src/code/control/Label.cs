using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTrining.src.code.control
{
    public class Label : ControlSelenium
    {
        public Label(By locator) : base(locator)
        {
        }

        public Boolean ContainsText(string text)
        {
            try
            {
                FindControl();
                Console.WriteLine("control.Text: "+control.Text);
                return control.Text==text;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
