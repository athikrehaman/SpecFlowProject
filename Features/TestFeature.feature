Feature: Test Login Functionality

A Feature to Test the login functionality


Scenario: Verify login funtionality
	Given User is on login page
	When User enters the username and password
	And User clicks on login button
	Then User is navigated to home page
