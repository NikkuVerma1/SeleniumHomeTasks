Feature: RecruitmentFeature

A short summary of the feature

@recruitment
Scenario Outline: Adding candidate for recruitment
	Given I logged into OrangeHRM application successfully
	And I clicked on recruitment tab
	When I click on add button
	Then I should navigate to 'Add Candidate' page
	When I enter '<FirstName>', '<LastName>' and '<Email>'
	And I click save button
	Then the candidate should be added
	Examples: 
	| FirstName | LastName | Email         |
	| Pihu      | Verma    | pihu@mail.com |

@recruitment
Scenario Outline: Adding candidate for recruitment without having last name
	Given I logged into OrangeHRM application successfully
	And I clicked on recruitment tab
	When I click on add button
	Then I should navigate to 'Add Candidate' page
	When I enter '<FirstName>', leave '<LastName>' as blank and enter '<Email>'
	And I click save button
	Then the candidate should not be added and error message should be displayed
	Examples: 
	| FirstName | LastName | Email         |
	| Pihu      |          | pihu@mail.com |
