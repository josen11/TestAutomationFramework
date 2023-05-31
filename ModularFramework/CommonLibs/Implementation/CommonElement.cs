using OpenQA.Selenium;

namespace CommonLibs.Implementation
{
    public class CommonElement
    {
        // General methods by UI Element
        // Use Expression body for methods
        public void ClickElement(IWebElement element) => element.Click();

        public void ClearElement(IWebElement element) => element.Clear();

        public void SetElement(IWebElement element, string textToPass) => element.SendKeys(textToPass);

        public bool IsElementDisplayed(IWebElement element) => element.Displayed;

        public bool IsElementSelected(IWebElement element) => element.Selected;

        public bool IsElementEnabled(IWebElement element) => element.Enabled;  

    }
}