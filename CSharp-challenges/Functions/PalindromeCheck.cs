using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_challenges.Functions
{
    public class PalindromeCheck
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false; // An empty string is not considered a palindrome
            }
            // Remove whitespace and punctuation, and convert to lowercase
            input = new string(input
                .Where(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c))
                .ToArray());

            // Compare the normalized input with its reverse
            char[] reversedInput = input.ToCharArray();
            Array.Reverse(reversedInput);
            return input.SequenceEqual(new string(reversedInput));
        }
    }
}
