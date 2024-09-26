Feature: OrangeHRMInvalid

Test for the Invalid Login

Scenario Outline: Verify Invalid login for Orange HRM
	Given User is on the login Page
	When User enters the Invalid "<usrnm>" and "<psswd>" in the credentials field
	When User clicks on the login Button
	Then Invalid Credentials is displayed

Examples: 
	| usrnm | psswd |
	| admin | 12345 |
