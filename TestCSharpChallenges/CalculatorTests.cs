using CSharp_challenges.Functions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpChallenges
{
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [Fact]
        public void CheckCalculation_ValidInput_ReturnsTrue()
        {
            string input = "3 + 5 * (2 - 8)";
            bool result = calculator.CheckCalculation(input);
            Assert.True(result);
        }

        [Fact]
        public void CheckCalculation_InvalidInput_ReturnsFalse()
        {
            string input = "3 + 5 * (2 - 8))";
            bool result = calculator.CheckCalculation(input);
            Assert.False(result);
        }

        [Fact]
        public void CheckCalculation_EmptyInput_ReturnsFalse()
        {
            string input = "";
            bool result = calculator.CheckCalculation(input);
            Assert.False(result);
        }

        [Fact]
        public void CheckCalculation_OnlyOperators_ReturnsFalse()
        {
            string input = "+ - * /";
            bool result = calculator.CheckCalculation(input);
            Assert.False(result);
        }

        [Fact]
        public void Calculate_ReturnsCorrectResult()
        {
            string input = "3 + 5 * (2 - 8)";
            double result = calculator.Calculate(input);
            Assert.Equal(-27, result);
        }

        [Fact]
        public void Calculate_ReturnsThree()
        {
            string input = "(3 + 4) * (5 - 2) / 7";
            double result = calculator.Calculate(input);
            Assert.Equal(3, result);
        }
    }
}
