Feature: CheckoutFeature

A short summary of the feature

@checkout
Scenario Outline: Verify the checkout process
	Given I log in to application successfully
	And I navigate to cart page
	When I click on checkout button
	And I enter '<FirstName>', '<LastName>' and '<PostalCode>'
	And I click continue button
	Then I should see names and prices of items for checkout
	When I click finish button to complete the checkout process
	Then checkout process should be completed successfully
	Examples: 
	| FirstName | LastName | PostalCode |
	| Pihu      | Verma    | 123456     |
