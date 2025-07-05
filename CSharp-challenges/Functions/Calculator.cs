using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CSharp_challenges.Functions
{
    public class Calculator
    {
        private readonly ILogger<Calculator> _logger;

        public Calculator(ILogger<Calculator> logger)
        {
            _logger = logger;
        }

        public double Calculate(string input) {
            return 0;
        }

        public bool CheckCalculation(string input) 
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            
            char[] operators = { '+', '-', '*', '/' };
            bool previousCharIsOperator = false;

            // Check for invalid characters
            char[] validChars = "0123456789+-*/(). ".ToCharArray();
            foreach (char c in input)
            {
                if (!validChars.Contains(c))
                {
                    return false;
                }

                if(operators.Contains(c) && input.IndexOf(c) == 0)
                {
                    return false; // Operator cannot be the first character
                }

                if (operators.Contains(c))
                {
                    if (previousCharIsOperator)
                    {
                        return false; // Two operators in a row is invalid
                    }
                    previousCharIsOperator = true; // Mark that the last character was an operator
                }
                else if (char.IsDigit(c) || c == ' ' || c == '(' || c == ')')
                {
                    if (previousCharIsOperator && c != ' ')
                    {
                        previousCharIsOperator = false; // Reset if the current character is not an operator
                    }
                }
                else
                {
                    return false; // Invalid character found
                }
            }

            // Additional checks can be added here, such as checking for balanced parentheses, etc.

            if (input.Count(c => c == '(') != input.Count(c => c == ')'))
            {
                return false; // Unbalanced parentheses
            }

            return true;
        }
    }
}
