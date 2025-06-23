using CSharp_challenges.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpChallenges
{
    public class EvenOrOddTest
    {
        EvenOrOdd evenOrOdd = new EvenOrOdd();

        [Fact]
        public void TestEven()
        {
            bool result = evenOrOdd.IsEvenOrOdd(10292);

            Assert.True(result);
        }

        [Fact]
        public void TestEven2()
        {
            bool result = evenOrOdd.IsEvenOrOdd(8);

            Assert.True(result);
        }

        [Fact]
        public void TestOdd()
        {
            bool result = evenOrOdd.IsEvenOrOdd(43);

            Assert.False(result);
        }

        [Fact]
        public void TestOdd2()
        {
            bool result = evenOrOdd.IsEvenOrOdd(128467);

            Assert.False(result);
        }
    }
}
