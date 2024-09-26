Feature: ParabankRegister

Testing for the Parabank Rgister page


Scenario Outline: Verifying the Registration of Parabank
	Given User is on the Parabank page and clicks on Register Link
	When User is on the register page and enters "<fname>" and "<lname>" and "<address>" and "<city>" and "<state>" and "<zip>" and "<pnum>" and "<ssn>" and "<username>" and "<pass>" and "<confpass>"
	When User clicks on register button
	Then User is registered
	

Examples: 

	| fname | lname   | address | city      | state     | zip    | pnum       | ssn | username | pass  | confpass |
	| Athik | Rehaman | Kapikad | Mangalore | Karnataka | 560001 | 6848397483 | 001 | atreh    | 12345 | 12345    |
