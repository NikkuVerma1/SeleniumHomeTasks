Feature: CartFeature

A short summary of the feature

@cart
Scenario: Verify item name and price in cart page
	Given I logged in to application successfully
	When I navigate to cart page
	Then I should see names and prices of items added to the cart
