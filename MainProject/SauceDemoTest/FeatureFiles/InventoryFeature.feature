Feature: InventoryFeature

A short summary of the feature
@inventory
Scenario: Adding items to cart from inventory
	Given I logged into application successfully
	And I navigated to inventory page
	When I click on 'ADD TO CART' button for item
	Then the item should be added to the cart
