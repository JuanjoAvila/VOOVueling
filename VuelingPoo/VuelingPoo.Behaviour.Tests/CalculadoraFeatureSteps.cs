using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace VuelingPoo.Behaviour.Tests
{
    [Binding]
    public class CalculadoraFeatureSteps
    {
        private int result;
        private readonly ICalculadora calculator = new Calculadora();
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculatorSum(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculatorSum(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press Suma Method")]
        public void WhenIPressSumaMethod()
        {
            result = calculator.Suma(calculator.FirstNumber,calculator.SecondNumber);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreenSum(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculatorReduct(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculatorReduct(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press Suma Method")]
        public void WhenIPressRestaMethod()
        {
            result = calculator.Resta(calculator.FirstNumber, calculator.SecondNumber);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreenReducted(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculatorDivision(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculatorDivision(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press Suma Method")]
        public void WhenIPressDivisionMethod()
        {
            result = calculator.Division(calculator.FirstNumber, calculator.SecondNumber);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreenDivsion(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculatorMultiplicate(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculatorMultiplicate(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press Suma Method")]
        public void WhenIPressMultiplicacionMethod()
        {
            result = calculator.Multiplicacion(calculator.FirstNumber, calculator.SecondNumber);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreenMultiplication(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
