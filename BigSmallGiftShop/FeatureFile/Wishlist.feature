Feature: Wishlist
	Check Wishlist

@mytag
Scenario: Add item to Wishlist
	Given User is on home page  
    When click on unique rakhi
    And click on item 
	And click add to wishlist button
	Then item should be successfullly added in wishlist.

	