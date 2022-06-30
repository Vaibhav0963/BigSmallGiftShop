Feature: BigSmall
   check  all functions perform  succesfully or not  

@mytag
Scenario:To check New User Create Acoount Succesfully or Not 
	Given user is on the HomePage
	When User On Login page
	And User Enter Email Id
	And User Enter Password
	And User Click on SignIn Button
	And Go to Homepage
	Then User shoud able to Create Account Succesfully







