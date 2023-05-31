using CommonLibs.Implementation;
using NUnit.Framework;

namespace Guru99Tests.tests
{
    public class LoginPageTests:BaseTests
    {
        [Test]
        public void Test1()
        {
            CommonDriver CmmDriver = new CommonDriver("chrome");
            CmmDriver.NavigateToURL("https://demo.guru99.com/v4/");

        }

        public void VerifyLoginTest()
        {
            // Go to url and register a new user with email, this generates the user and password.
            loginPage.LoginToApplication("mngr288890","sutydum");

            // Assert to evalute the result
            string expectedTitle = "Guru99 Bank Manager Home Page";
            string actualTitle = CmnDriver.GetPageTitle();
            Assert.AreEqual(expectedTitle,actualTitle);
        }
    }
}