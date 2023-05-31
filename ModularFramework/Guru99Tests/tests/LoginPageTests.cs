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
        }
    }
}