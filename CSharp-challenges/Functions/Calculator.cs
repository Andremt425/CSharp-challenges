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
        private readonly ILogger<Calculator> _logger = new LoggerFactory().CreateLogger<Calculator>();

        public double Calculate(string input) {
            
            if (string.IsNullOrWhiteSpace(input))
            {
                _logger.LogWarning("Input is null or empty.");
                return 0;
            }

            try
            {
                // Use DataTable to evaluate the expression
                var dataTable = new System.Data.DataTable();
                var result = dataTable.Compute(input, string.Empty);
                return Convert.ToDouble(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error calculating expression: {ex.Message}");
                return 0;
            }
        }

        public bool CheckCalculation(string input) 
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                _logger.LogWarning("Input is null or empty.");
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
                    _logger.LogWarning($"Invalid character '{c}' found in input.");
                    return false;
                }

                if(operators.Contains(c) && input.IndexOf(c) == 0)
                {
                    _logger.LogWarning($"Operator '{c}' cannot be the first character in the input.");
                    return false;
                }

                if (operators.Contains(c))
                {
                    if (previousCharIsOperator)
                    {
                        _logger.LogWarning($"Two operators in a row found: '{c}' after previous operator.");
                        return false;
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
            }

            if (input.Count(c => c == '(') != input.Count(c => c == ')'))
            {
                _logger.LogWarning("Unbalanced parentheses found in input.");
                return false;
            }

            return true;
        }
    }
}
