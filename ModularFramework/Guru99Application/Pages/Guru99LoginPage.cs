using OpenQA.Selenium;

namespace Guru99Application.Pages
{
    public class Guru99LoginPage:BasePage
    {
        // POM Page Object Model = Each Page hast to be each own class
        private IWebDriver _driver;
        private IWebElement username => _driver.FindElement(By.Name("uid"));
        private IWebElement password => _driver.FindElement(By.Name("password"));
        private IWebElement loginButton=> _driver.FindElement(By.Name("btnLogin"));

        // Initialize driver
        public Guru99LoginPage(IWebDriver driver)
        {
            _driver=driver;
        }

        public void LoginToApplication(string sUsername, string sPassword)
        {
            cmnElement.SetElement(username,sUsername);
            cmnElement.SetElement(password,sPassword);
            cmnElement.ClickElement(loginButton);
        }
    }

}