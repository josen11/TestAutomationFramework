using System;
using System.IO;
using OpenQA.Selenium;

namespace CommonLibs.Utils 
{
    public class ScreenshotUtils
    {
        ITakesScreenshot camera;
        public ScreenshotUtils (IWebDriver driver)
        {
            camera = (ITakesScreenshot) driver;
        }
        public void CaptureAndSaveScreenshot (string fileName)
        {
            // Save in the same variable using _
            _ = fileName.Trim();

            if(File.Exists(fileName))
            {
                throw new Exception("Filename already exists");
            }

            Screenshot screenshoot= camera.GetScreenshot();
            screenshoot.SaveAsFile(fileName);
        }

    }
}