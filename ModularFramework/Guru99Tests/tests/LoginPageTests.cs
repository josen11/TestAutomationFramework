using CommonLibs.Implementation;
using NUnit.Framework;

namespace Guru99Tests.tests
{
    public class LoginPageTests
    {
        [Test]
        public void Test1()
        {
            CommonDriver CmmDriver = new CommonDriver("chrome");
            CmmDriver.NavigateToURL("https://demo.guru99.com/v4/");

        }
    }
}