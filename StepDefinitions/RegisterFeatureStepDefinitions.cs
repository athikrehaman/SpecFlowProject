using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Analytics;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class RegisterFeatureStepDefinitions
    {
        [Given(@"User is on the Register Page")]
        public void GivenUserIsOnTheRegisterPage()
        {
            Console.WriteLine("User has reached Register page");
        }

        [When(@"User enters the Register credentials")]
        public void WhenUserEntersTheRegisterCredentials()
        {
            Console.WriteLine("User Enters the Register Credentials");
        }

        [When(@"User clicks on the Register button")]
        public void WhenUserClicksOnTheRegisterButton()
        {
            Console.WriteLine("User has Clicked Register button");
        }

        [Then(@"User is successfullly Registered")]
        public void ThenUserIsSuccessfulllyRegistered()
        {
            Console.WriteLine("Successfully Registered");
        }

        [When(@"User enters ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersAndAndAndAndAndAndAndAndAndAnd(string fname, string lname, string address, string city, string state, string zip, string pnum, string ssn, string username, string pass, string confpass)
        {
            Console.WriteLine(fname + " , " + lname + " , " + address + " , " + city + " , " + state + " , " + zip + " , " + pnum + " , " + ssn + " , " + username + " , " + pass + " , " + confpass);
        }

        [When(@"User clicks on Register button")]
        public void WhenUserClicksOnRegisterButton()
        {
            Console.WriteLine("User has Clicked Register button");
        }

        [Then(@"User is successfully Registered")]
        public void ThenUserIsSuccessfullyRegistered()
        {
            Console.WriteLine("Successfully Registered");
        }
    }
}
