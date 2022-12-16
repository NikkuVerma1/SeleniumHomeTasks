Feature: 1. LoginFeature

A short summary of the feature

@login
Scenario Outline: Login to application with valid credentials
	Given I launched the SauceDemo application using 'https://www.saucedemo.com/'
	When I enter '<Username>' and '<Password>'
	And I click on Login button
	Then I should be successfully logged in to application
	Examples: 
	| Username                | Password     |
	| standard_user           | secret_sauce |
	| locked_out_user         | secret_sauce |
	| problem_user            | secret_sauce |
	| performance_glitch_user | secret_sauce |
