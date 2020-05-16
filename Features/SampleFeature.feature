Feature: SampleFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add two numbers
	Given I have entered <numbers1> into the calculator
	And I have entered <String1> into the calculator
	When I press add
	Then the result should be 120 on the screen
	Examples: 
	| numbers1 |String1  |
	| 25       | text1  |
	| 30       | text2 |

