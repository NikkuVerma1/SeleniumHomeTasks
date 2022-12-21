Feature: AdminFeature

A short summary of the feature

@admin
Scenario: Verify user search in admin page
	Given I logged into OrangeHRM application successfully
	And I clicked on admin tab
	Then list of users should be displayed
	When I enter username in username field from list and click search button
	Then related user record should be displayed

@admin
Scenario Outline: Add user in admin page
	Given I logged into OrangeHRM application successfully
	And I clicked on admin tab
	When I click add button
	Then I should be navigated to add user page
	When I select user role
	And I enter '<EmployeeName>'
	And I select status
	And I key in '<UserName>'
	And I type in '<Password>' and '<ConfirmPassword>'
	And I submit details using save button
	Then user should be added 
	Examples: 
	| EmployeeName | UserName | Password | ConfirmPassword |
	| Sagar        | abcd.xyz | Aa@12345 | Aa@12345        |