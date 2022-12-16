Feature: 4. CheckoutFeature

A short summary of the feature

@checkout
Scenario Outline: 4.1 Verify the checkout process
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

@checkout
Scenario Outline: 4.2 Verify the checkout process for incomplete user details
	Given I log in to application successfully
	And I navigate to cart page
	When I click on checkout button
	And I skip entering one of either '<FirstName>', '<LastName>' or '<PostalCode>'
	And I click continue button
	Then I should see error message
	Examples: 
	| FirstName | LastName | PostalCode |
	| Pihu      | Verma    |            |
	|           | Verma    | 123456     |
	| Pihu      |          | 123456     |