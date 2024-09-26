using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.Hooks
{
    [Binding]
    internal class Hooks
    {

        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Setup()
        {
            //Console.WriteLine("Running before every scenario");
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();
            _scenarioContext["WebDriver"] = driver;
        }


        [AfterScenario]
        public void TearDown()
        {
            //Console.WriteLine("Running after every scenario");

            var driver = _scenarioContext["WebDriver"] as IWebDriver;
            driver?.Quit();
        }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            TestContext.Progress.WriteLine("Running before TestRun");
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
            TestContext.Progress.WriteLine("Running after TestRun");
        }


        [BeforeStep]
        public void BeforeStep()
        {
            Console.WriteLine("Running before step");
        }


        [AfterStep]
        public void AfterStep()
        {
            Console.WriteLine("Running after step");
        }
    }
}
