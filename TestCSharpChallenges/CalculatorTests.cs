using CSharp_challenges.Functions;
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
    }
}
