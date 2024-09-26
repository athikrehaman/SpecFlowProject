Feature: RegisterFeature

A Feature to Test the Register functionality

Background: 
	Given User is on the Register Page

Scenario: Register Functionality
	When User enters the Register credentials
	And User clicks on the Register button
	Then User is successfullly Registered


Scenario Outline: Register Functionality using Parameters
	When User enters "<fname>" and "<lname>" and "<address>" and "<city>" and "<state>" and "<zip>" and "<pnum>" and "<ssn>" and "<username>" and "<pass>" and "<confpass>"
	And User clicks on Register button
	Then User is successfully Registered


Examples: 
| fname | lname   | address | city      | state     | zip    | pnum       | ssn | username | pass  | confpass |
| Athik | Rehaman | Kapikad | Mangalore | Karnataka | 560001 | 8463094858 | 001 | atreh    | 12345 | 12345    |