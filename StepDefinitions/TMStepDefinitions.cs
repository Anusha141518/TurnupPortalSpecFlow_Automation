using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TurnupPortalSpecFlow_Automation.Pages;
using TurnupPortalSpecFlow_Automation.Utilities;

namespace TurnupPortalSpecFlow_Automation.StepDefinitions
{
    [Binding]
    public class TMStepDefinitions : TMPage
    {
        IWebDriver driver = new ChromeDriver();
        LoginPage loginPageObject = new LoginPage();
        HomePage homePageObject = new HomePage();
        TMPage tmPageObject = new TMPage();

        [Given(@"I log into Turnup portal")]
        public void GivenILogIntoTurnupPortal()
        {
            loginPageObject.LoginAction(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePageObject.GoToTMPage(driver);
        }

        [When(@"I create a new Time and Material record '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenICreateANewTimeAndMaterialRecord(string code, string description, string price)
        {
            tmPageObject.CreateTimeRecord(driver, code, description, price);
        }

        [Then(@"the record should be saved '([^']*)'")]
        public void ThenTheRecordShouldBeSaved(string code)
        {
            tmPageObject.AssertCreateTimeRecord(driver, code);
            driver.Quit();
        }

        [When(@"I edit an existing Time and Material record '([^']*)' '([^']*)'")]
        public void WhenIEditAnExistingTimeAndMaterialRecord(string oldCode, string newCode)
        {
            tmPageObject.EditTimeRecord(driver, oldCode, newCode);
        }

        [Then(@"the record should be updated '([^']*)'")]
        public void ThenTheRecordShouldBeUpdated(string newCode)
        {
            tmPageObject.AssertEditTimeRecord(driver, newCode);
            driver.Quit();
        }

        [When(@"I delete an existing Time and Material record '([^']*)'")]
        public void WhenIDeleteAnExistingTimeAndMaterialRecord(string code)
        {
            tmPageObject.DeleteTimeRecord(driver, code);
        }

        [Then(@"the record should be deleted '([^']*)'")]
        public void ThenTheRecordShouldBeDeleted(string code)
        {
            tmPageObject.AssertDeleteTimeRecord(driver, code);
            driver.Quit();
        }
    }
}
