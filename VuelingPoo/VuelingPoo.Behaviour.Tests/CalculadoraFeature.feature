Feature: CalculadoraFeature
	I want to calculate some features.
	Calculate the sum of two numbers
	Calculate the reduction of two numbers
	Calculate the division of two numbers.
	Calculate the multiplication of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 5 into the calculator
	And I have entered 7 into the calculator
	When I press Suma method
	Then the result should be 12 on the screen

@mytag
Scenario: Reduct two numbers
	Given I have entered 10 into the calculator
	And I have entered 5 into the calculator
	When I press add
	Then the result should be 5 on the screen

@mytag
Scenario: Divide two numbers
	Given I have entered 10 into the calculator
	And I have entered 2 into the calculator
	When I press add
	Then the result should be 5 on the screen

@mytag
Scenario: Multiplicate two numbers
	Given I have entered 5 into the calculator
	And I have entered 2 into the calculator
	When I press add
	Then the result should be 10 on the screen