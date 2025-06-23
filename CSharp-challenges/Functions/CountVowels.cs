using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_challenges.Functions
{
    public class CountVowels
    {
        public int CountVowelsInString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0; // Return 0 if the string is null or empty
            }
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char c in input.ToLower())
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

    }
}
