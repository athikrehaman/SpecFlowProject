@Sanity
Feature: TestLoginWithParams

Test Login with data parameters

Background: 
	Given User is on login page


Scenario: Verify login funtionality
	When User enters the username and password
	And User clicks on login button
	Then User is navigated to home page



Scenario Outline: Verify login funtionality With Test Parameters
	When User enters the "<username>" and "<password>"
	And User clicks on login button
	Then User is navigated to home page
	Then User selected city and country information
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |

Examples: 

| username | password |
| tom      | Harry    |
| jerry    | Mathew   |