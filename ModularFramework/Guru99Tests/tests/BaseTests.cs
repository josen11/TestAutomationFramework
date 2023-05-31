using System;
using System.IO;
using CommonLibs.Implementation;
using Guru99Application.Pages;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace Guru99Tests.tests
{
    public class BaseTests
    {
        public CommonDriver CmnDriver;
        public Guru99LoginPage loginPage;
        private IConfiguration _configuration;
        string url;
        string currentProjectDirectory;

        [OneTimeSetUp]
        public void preSetup()
        {
            string workingDirectory = Environment.CurrentDirectory;
            currentProjectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            _configuration= new ConfigurationBuilder().AddJsonFile(currentProjectDirectory+"/config/appSettings.json").Build();

        }

        [SetUp]
        public void Setup()
        {
            string browserType = _configuration["browserType"];
            CmnDriver = new CommonDriver(browserType);
            url=_configuration["baseUrl"];
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