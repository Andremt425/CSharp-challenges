using CSharp_challenges.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpChallenges
{
    public class CountVowelsTest
    {
        private readonly CountVowels _countVowels = new CountVowels();

        [Fact]
        public void TestCountVowelsInString()
        {
            int result = _countVowels.CountVowelsInString("Hello World");
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestCountVowelsInStringEmpty()
        {
            int result = _countVowels.CountVowelsInString("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestCountVowelsInStringNull()
        {
            int result = _countVowels.CountVowelsInString(null);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestCountVowelsInStringNoVowels()
        {
            int result = _countVowels.CountVowelsInString("rhythm");
            Assert.Equal(0, result);
        }
    }
}
