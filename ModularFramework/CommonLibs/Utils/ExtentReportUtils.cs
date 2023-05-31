using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace CommonLibs.Utils 
{
    public class ExtentReportUtils
    {
        // Go to command pallette, Nuget add new package, 
        // type ExtentReport, Select ExtentReports and last stable version (4.1.0), then install it in CommonLibs Proj
        // Let confirm in .csproj file the dependency was added
        private ExtentHtmlReporter extentHtmlReporter;
        private ExtentReports extentReports;
        private ExtentTest extentTest;
        public ExtentReportUtils(string htmlReportFileName)
        {
            extentHtmlReporter = new ExtentHtmlReporter(htmlReportFileName);
            extentReports = new ExtentReports();
            extentReports.AttachReporter(extentHtmlReporter);
        }

        public void createATestCase (string testCaseName)
        {
            extentTest = extentReports.CreateTest(testCaseName);
        }
        public void addTestLog(Status status, string comment)
        {
            extentTest.Log(status, comment);
        }
        public void addScreenshot (string screenshootFileName)
        {
            extentTest.AddScreenCaptureFromPath(screenshootFileName);
        }
        public void flushReport()
        {
            extentReports.Flush();
        }
    }
}
