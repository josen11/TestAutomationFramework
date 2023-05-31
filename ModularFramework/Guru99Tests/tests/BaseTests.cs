using CommonLibs.Implementation;
using Guru99Application.Pages;
using NUnit.Framework;

namespace Guru99Tests.tests
{
    public class BaseTests
    {
        public CommonDriver CmnDriver;
        public Guru99LoginPage loginPage;
        string url = "http://demo.guru99.com/v4";

        [SetUp]
        public void Setup()
        {
            CmnDriver = new CommonDriver("chrome");
            CmnDriver.NavigateToURL(url);
            loginPage=new Guru99LoginPage(CmnDriver.Driver);
        }

        [TearDown]
        public void TearDown()
        {
            CmnDriver.CloseAllBrowser();
        }


    }
}