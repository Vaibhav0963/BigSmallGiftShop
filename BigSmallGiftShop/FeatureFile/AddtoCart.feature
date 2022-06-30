Feature: AddtoCart
	Check Add To Cart

@mytag
Scenario: Add item to Add To Cart
	Given User is on home page  
    When click on NewProduct
    And click on any one item 
	And click add to cart button
	Then item should be successfullly added in Cart
	