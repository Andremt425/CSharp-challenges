using CSharp_challenges.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpChallenges
{
    public class FrequentCharacterTest
    {
        FrequentCharacterCheck frequentCharacterCheck = new FrequentCharacterCheck();

        [Fact]
        public void TestCalculateFrequentCharacterTrue()
        {
            string input = "hello world";

            char character = frequentCharacterCheck.CalculateFrequentCharacter(input);
            
            Assert.Equal('l', character);
        }

        [Fact]
        public void TestCalculateFrequentCharacterFalse()
        {
            string input = "The driver no gas";

            char character = frequentCharacterCheck.CalculateFrequentCharacter(input);

            Assert.NotEqual('a', character);
        }
    }
}
