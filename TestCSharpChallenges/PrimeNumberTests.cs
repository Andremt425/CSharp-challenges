using CSharp_challenges.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpChallenges
{
    public class PrimeNumberTests
    {
        PrimeNumber primeNumber = new PrimeNumber();

        [Fact]
        public void TestPrimeNumber()
        {
            bool result = primeNumber.IsPrime(3);

            Assert.True(result);
        }

        [Fact]
        public void TestPrimeNumberFalse()
        {
            bool result = primeNumber.IsPrime(1);

            Assert.False(result);
        }

        [Fact]
        public void TestPrimeNumber2()
        {
            bool result = primeNumber.IsPrime(43);

            Assert.True(result);
        }

        [Fact]
        public void TestPrimeNumberFalse2()
        {
            bool result = primeNumber.IsPrime(24);

            Assert.False(result);
        }

        [Fact]
        public void TestPrimeNumber3()
        {
            bool result = primeNumber.IsPrime(173);

            Assert.True(result);
        }

        [Fact]
        public void TestPrimeNumberFalse3()
        {
            bool result = primeNumber.IsPrime(114);

            Assert.False(result);
        }
    }
}
