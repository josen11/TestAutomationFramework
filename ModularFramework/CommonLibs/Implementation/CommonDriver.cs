
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace CommonLibs.Implementation
{
    public class CommonDriver
    {
        private int pageLoadTimeout;
        private int elementDetectionTimeout;
        
        // Driver to handle browrser in Selenium as Hidden property, only read.
        public IWebDriver Driver {get; private set;} 
        
        // Encapsulate field and use property. It's not required outside
        public int PageLoadTimeout { private get => pageLoadTimeout; set => pageLoadTimeout=value;}
        public int ElementDetectionTimeout { private get => elementDetectionTimeout; set => elementDetectionTimeout = value; }

        public CommonDriver(string browserType)
        {
            browserType=browserType.Trim();
            pageLoadTimeout =60;
            elementDetectionTimeout=10;
            if(browserType.Equals("chrome"))
            {
                Driver =new ChromeDriver();
            } 
            else if(browserType.Equals("edge"))
            {
                Driver =new EdgeDriver();
            }
            else 
            {
                throw new System.Exception("Invalid browser type");        
            }
        }

        public void NavigateToURL(string url)
        {
            url= url.Trim();
            Driver.Manage().Timeouts().PageLoad=TimeSpan.FromSeconds(pageLoadTimeout);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(elementDetectionTimeout);
            Driver.Url = url;
        }

        public void CloseBrowser()
        {
            if(Driver != null)
            {
                Driver.Close();
            }
        }

        public void CloseAllBrowser()
        {
            if(Driver != null)
            {
                Driver.Quit();
            }
        }   
   }
}