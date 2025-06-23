using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_challenges.Functions
{
    public class FrequentCharacterCheck
    {
        public void CalculateFrequentCharacter() {
            
            Console.WriteLine("Enter a string to check for the most frequent character:");

            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No string was entered.");
            }

            var frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }

            char mostFrequentChar = frequency.OrderByDescending(x => x.Value).First().Key;
            Console.WriteLine($"The most frequent character is: {mostFrequentChar}");

        }
    }
}
