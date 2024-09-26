using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class OrangeHRMInvalidStepDefinitions
    {
        private IWebDriver _driver;



        [Given(@"User is on the login Page")]
        public void GivenUserIsOnTheLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the Invalid ""([^""]*)"" and ""([^""]*)"" in the credentials field")]
        public void WhenUserEntersTheInvalidAndInTheCredentialsField(string admin, string p1)
        {
            IWebElement usrnm = _driver.FindElement(By.XPath("//input[@name = 'username']"));
            usrnm.SendKeys(admin);
            Thread.Sleep(1000);

            IWebElement pswd = _driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            pswd.SendKeys(p1);
            Thread.Sleep(1000);
        }

        [When(@"User clicks on the login Button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));
            loginbutton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Invalid Credentials is displayed")]
        public void ThenInvalidCredentialsIsDisplayed()
        {
            Console.WriteLine("Invalid is printed");

            _driver.Close();
        }
    }
}
