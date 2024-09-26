using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestLoginWithParamsStepDefinitions
    {
        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            Console.WriteLine("The username "+username+" and Password is "+password);
        }

        [Then(@"User selected city and country information")]
        public void ThenUserSelectedCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                String city = row["city"];
                String country = row["country"];
                Console.WriteLine(city+" , "+country);
            }
        }

    }
}
