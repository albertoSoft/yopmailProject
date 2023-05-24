using OpenQA.Selenium;
using SeleniumTrining.src.code.factoryBrowser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTrining.src.code.session
{
    public class Session
    {
        // atributo del mismo tipo
        private static Session instance=null;
        private IWebDriver browser;
        //constructor privado
        private Session()
        {
            browser = FactoryBrowser.Make("chrome").Create();
        }
        // metodo estatico público para su acceso global
        public static Session Instance()
        {
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }

        public void CloseBrowser()
        {
            instance=null; 
            browser.Close();
            browser.Quit();
        }
        public IWebDriver GetBrowser()
        {
            return browser;
        }
    }
}
