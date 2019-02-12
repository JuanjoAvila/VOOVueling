Feature: CalculadoraFeature
	I want to calculate some features.
	Calculate the sum of two numbers
	Calculate the reduct of two numbers
	Calculate the division of two numbers.
	Calculate the multiplication of two numbers

Scenario: Add two numbers
	Given I have entered 5 into the calculator
	And I have also entered 7 into the calculator
	When I press Suma Button
	Then the result should be 12 on the screen

Scenario: Reduct two numbers
	Given I have entered 10 into the calculator
	And I have also entered 5 into the calculator
	When I press Reduct Button
	Then the result should be 5 on the screen


Scenario: Divide two numbers
	Given I have entered 10 into the calculator
	And I have also entered 2 into the calculator
	When I press Divide Button
	Then the result should be 5 on the screen

Scenario: Multiplicate two numbers
	Given I have entered 5 into the calculator
	And I have also entered 2 into the calculator
	When I press Multiplication Button
	Then the result should be 10 on the screen