using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class ParabankRegisterStepDefinitions
    {

        IWebDriver _driver;


        [Given(@"User is on the Parabank page and clicks on Register Link")]
        public void GivenUserIsOnTheParabankPageAndClicksOnRegisterLink()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            IWebElement RegisterLink = _driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));
            RegisterLink.Click();
        }

        [When(@"User is on the register page and enters ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserIsOnTheRegisterPageAndEntersAndAndAndAndAndAndAndAndAndAnd(string fname, string lname, string address, string city, string state, string p5, string p6, string p7, string uname, string p9, string p10)
        {
            IWebElement FstName = _driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            FstName.SendKeys(fname);

            IWebElement LstName = _driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            LstName.SendKeys(lname);

            IWebElement adrs = _driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            adrs.SendKeys(address);

            IWebElement cty = _driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            cty.SendKeys(city);

            IWebElement ste = _driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            ste.SendKeys(state);

            IWebElement zip = _driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            zip.SendKeys(p5);

            IWebElement pnum = _driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            pnum.SendKeys(p6);

            IWebElement ssn = _driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            ssn.SendKeys(p7);

            IWebElement username = _driver.FindElement(By.XPath("//input[@id='customer.username']"));
            username.SendKeys(uname);

            IWebElement password = _driver.FindElement(By.XPath("//input[@id='customer.password']"));
            password.SendKeys(p9);

            IWebElement Confirm = _driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            Confirm.SendKeys(p10);

            Thread.Sleep(4000);
        }

        [When(@"User clicks on register button")]
        public void WhenUserClicksOnRegisterButton()
        {
            IWebElement Registerbutton = _driver.FindElement(By.XPath("//input[@value='Register']"));
            Registerbutton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"User is registered")]
        public void ThenUserIsRegistered()
        {
            Console.WriteLine("Registered");

            _driver.Close();
        }

        /*[When(@"User is on the login page enters ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserIsOnTheLoginPageEntersAnd(string uname, string p1)
        {
            IWebElement Username = _driver.FindElement(By.XPath("//input[@name='username']"));
            Username.SendKeys(uname);

            IWebElement Password = _driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys(p1);

            Thread.Sleep(2000);
        }

        [When(@"User clicks on The Login Button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            IWebElement LoginButton = _driver.FindElement(By.XPath("//input[@value='Log In']"));
            LoginButton.Click();
        }


        [Then(@"User is Logged in")]
        public void ThenUserIsLoggedIn()
        {
            _driver.Close();
        }*/

    }
}
