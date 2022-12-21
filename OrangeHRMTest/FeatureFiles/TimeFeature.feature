Feature: TimeFeature

A short summary of the feature

@time
Scenario: Verify the employees in Time page
	Given I logged into OrangeHRM application successfully
	And I clicked on time tab
	Then I should see list of employees and their pending timesheet period
