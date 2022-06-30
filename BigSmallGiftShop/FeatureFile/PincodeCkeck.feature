Feature: PincodeCkeck1
	Check to Delivery is Your Pincode Or Not 

@mytag
Scenario: Check to Delivery is Your Pincode Or Not 
	Given User Clicks on Gift card
	When User Clicks on price
    And User Enters PinCode
	And User Clicks on Check Button
	Then User shoud able to Your Pincode Or Not Succesfully
