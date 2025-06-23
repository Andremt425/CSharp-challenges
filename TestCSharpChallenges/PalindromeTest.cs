using CSharp_challenges.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpChallenges
{
    public class PalindromeTest
    {
        PalindromeCheck palindromeCheck = new PalindromeCheck();

        [Fact]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            
            string input = "madam";
            
            bool result = palindromeCheck.IsPalindrome(input);
            
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_InvalidPalindrome_ReturnsFalse()
        {
            string input = "hello";
            
            bool result = palindromeCheck.IsPalindrome(input);
            
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_EmptyString_ReturnsFalse()
        {
            string input = "";
            
            bool result = palindromeCheck.IsPalindrome(input);
            
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_Numeric_ReturnTrue()
        {
            string? input = "45654";
            
            bool result = palindromeCheck.IsPalindrome(input);
            
            Assert.True(result);
        }
    }
}
