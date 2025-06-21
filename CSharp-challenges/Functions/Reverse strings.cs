using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_challenges.Functions
{
    public class Reverse_strings
    {
        private static readonly Random _random = new Random();

        public string ReverseString(string input) 
        {
            if (string.IsNullOrEmpty(input))
            {
                return "No string was entered"; // Return the original string if it's null or empty
            }

            int choice = _random.Next(5); // Randomly choose a method to reverse the string

            switch (choice)
            {
                case 0:
                    return ReverseStringWithArray(input);
                case 1:
                    return ReverseStringWithLinq(input);
                case 2:
                    return ReverseStringWithLoop(input);
                case 3:
                    return ReverseStringWithRecursion(input);
                case 4:
                    return ReverseStringWithStack(input);
                default:
                    return ReverseStringWithArray(input); // Fallback if no method is chosen
            }
        }

        public string ReverseStringWithArray(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string ReverseStringWithLinq(string input)
        {
            return new string(input.Reverse().ToArray());
        }

        public string ReverseStringWithLoop(string input)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }

        public string ReverseStringWithRecursion(string input)
        { 
            if (input.Length == 1)
            {
                return input; // Base case: a single character is its own reverse
            }
            return input[^1] + ReverseStringWithRecursion(input[..^1]); // Recursive case
        }

        public string ReverseStringWithStack(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                stack.Push(c);
            }
            StringBuilder reversed = new StringBuilder();
            while (stack.Count > 0)
            {
                reversed.Append(stack.Pop());
            }
            return reversed.ToString();
        }

    }
}
