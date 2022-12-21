Feature: LoginFeature

A short summary of the feature

@login
Scenario Outline: Login to application with valid credentials
	Given I launched the OrangeHRM application using 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'
	When I enter '<Username>' and '<Password>'
	And I click on Login button
	Then I should be successfully logged in to application
	Examples: 
	| Username                | Password     |
	| Admin					  | admin123     |	
