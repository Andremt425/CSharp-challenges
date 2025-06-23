using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_challenges.Functions
{
    public class FrequentCharacterCheck
    {
        public char CalculateFrequentCharacter(string input) {
            
            if (string.IsNullOrEmpty(input))
            {
                return '\0';
            }

            var frequency = new Dictionary<char, int>();

            foreach (char c in input.ToLower())
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
            
            return mostFrequentChar;
        }
    }
}
