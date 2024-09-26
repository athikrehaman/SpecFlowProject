using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public OrangeHRMStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = scenarioContext["WebDriver"] as IWebDriver;
        }

        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string admin, string passworrd)
        {
            IWebElement usrnm = _driver.FindElement(By.XPath("//input[@name = 'username']"));
            usrnm.SendKeys(admin);
            Thread.Sleep(1000);

            IWebElement pswd = _driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            pswd.SendKeys(passworrd);
            Thread.Sleep(1000);

        }

        [When(@"User clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));
            loginbutton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"User is navigated to Home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            IWebElement admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));
            admin.Click();
            Thread.Sleep(2000);

        }
    }
}
