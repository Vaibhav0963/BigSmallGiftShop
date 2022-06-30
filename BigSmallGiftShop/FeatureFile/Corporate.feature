Feature: Corporate
	Check Coporate deatils

@mytag

Scenario:TO fill Coporate deatils
	Given user is on the HomePage 
    When  User click on Coproate
	And   User Enter fullname
	And   User Enter Email-id
    And   User Enter PhoneNo
	And   User Fill Enquiry
	And  Click on submit
	Then Verify the messeage