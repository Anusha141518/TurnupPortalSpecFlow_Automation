using NUnit.Framework;
using OpenQA.Selenium;

namespace TurnupPortalSpecFlow_Automation.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            try 
            { 
            // Navigate to Time & Materials Module
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            }

            catch(Exception ex)                
            {

                Assert.Fail("Turnup portal has not been displayed", ex.Message);
            }

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
