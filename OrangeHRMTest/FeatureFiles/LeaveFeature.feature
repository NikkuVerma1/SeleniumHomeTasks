Feature: LeaveFeature

A short summary of the feature

@leave
Scenario: Verify leave search in leave page
	Given I logged into OrangeHRM application successfully
	And I clicked on leave tab
	When I get from and to dates of leave from record
	And I enter the dates in respective fields
	And I click on search button
	Then related record should be displayed
