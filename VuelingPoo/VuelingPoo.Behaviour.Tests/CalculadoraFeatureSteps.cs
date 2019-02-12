using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace VuelingPoo.Behaviour.Tests
{
    [Binding]
    public class CalculadoraFeatureSteps
    {
        private int result;
        private readonly ICalculadora calculadora = new Calculadora();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculadora.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculadora.SecondNumber = number;
        }

        [When(@"I press Suma Button")]
        public void WhenIPressSumaButton()
        {
            result = calculadora.Suma(calculadora.FirstNumber, calculadora.SecondNumber);
        }

        [When(@"I press Reduct Button")]
        public void WhenIPressReductButton()
        {
            result = calculadora.Resta(calculadora.FirstNumber, calculadora.SecondNumber);
        }
        
        [When(@"I press Divide Button")]
        public void WhenIPressDivideButton()
        {
            result = calculadora.Division(calculadora.FirstNumber, calculadora.SecondNumber);
        }
        
        [When(@"I press Multiplication Button")]
        public void WhenIPressMultiplicationButton()
        {
            result = calculadora.Multiplicacion(calculadora.FirstNumber, calculadora.SecondNumber);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
