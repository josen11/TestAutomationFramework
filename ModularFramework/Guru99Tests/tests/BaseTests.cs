using System;
using System.IO;
using AventStack.ExtentReports;
using CommonLibs.Implementation;
using CommonLibs.Utils;
using Guru99Application.Pages;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace Guru99Tests.tests
{
    public class BaseTests
    {
        public CommonDriver CmnDriver;
        public Guru99LoginPage loginPage;
        private IConfigurationRoot _configuration;
        public ExtentReportUtils extentReportUtils;
        string url;
        string currentProjectDirectory;
        string currentSolutionDirectory;
        string reportFileName;
        [OneTimeSetUp]
        public void preSetup()
        {
            string workingDirectory = Environment.CurrentDirectory;
            currentProjectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            currentSolutionDirectory = Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName;
            reportFileName=currentSolutionDirectory+"/Reports/TestReports.html";
            extentReportUtils = new ExtentReportUtils(reportFileName);
            _configuration= new ConfigurationBuilder().AddJsonFile(currentProjectDirectory+"/config/appSettings.json").Build();
        }

        [SetUp]
        public void Setup()
        {
            extentReportUtils.createATestCase("Setup");
            string browserType = _configuration["browserType"];
            CmnDriver = new CommonDriver(browserType);
            
            extentReportUtils.addTestLog(Status.Info,"browser type: "+browserType);
            url=_configuration["baseUrl"];
            extentReportUtils.addTestLog(Status.Info,"Base url: "+url);
            
            CmnDriver.NavigateToURL(url);
            loginPage=new Guru99LoginPage(CmnDriver.Driver);
        }

        [TearDown]
        public void TearDown()
        {
            CmnDriver.CloseAllBrowser();
        }

        [OneTimeTearDown]
        public void PostCleanUp()
        {
            extentReportUtils.flushReport();
        }

    }
}