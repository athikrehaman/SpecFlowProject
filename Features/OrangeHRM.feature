Feature: OrangeHRM

Test Orange HRM Website login functionality

@tag1
Scenario: Verify login for orange hrm website
	Given User is on the orange hrm login page
	When User enters the "<username>" and "<password>" in the text fields
	When User clicks on the login button
	Then User is navigated to Home page 

Examples: 
| username | password |
| Admin    | admin123 |