using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace TurnupPortalSpecFlow_Automation.Utilities
{
    public class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locatorType == "Xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
            if (locatorType == "Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));
            }
        }

        public static void WaitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locatorType == "Xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
            }
            if (locatorType == "Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(locatorValue)));
            }
        }

    }
}