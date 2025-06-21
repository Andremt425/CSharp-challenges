using CSharp_challenges.Functions;

namespace TestCSharpChallenges
{
    public class ReverStringTests
    {

        ReverseStrings reverseStrings = new ReverseStrings();

        [Fact]
        public void TestRandomFunction()
        {       
            string result = reverseStrings.ReverseString("Random");

            Assert.Equal("modnaR", result);
        }

        [Fact]
        public void TestReverseStringWithArray()
        {
            string result = reverseStrings.ReverseStringWithArray("This should be reversed");

            Assert.Equal("desrever eb dluohs sihT", result);
        }

        [Fact]
        public void TestReverseStringWithLinq()
        {
            string result = reverseStrings.ReverseStringWithLinq("Sea shells on the sea shore");

            Assert.Equal("erohs aes eht no sllehs aeS", result);
        }

        [Fact]
        public void TestReverseStringWithLoop()
        {
            string result = reverseStrings.ReverseStringWithLoop("Another test case");

            Assert.Equal("esac tset rehtonA", result);
        }

        [Fact]
        public void TestReverseStringWithRecursion()
        {
            string result = reverseStrings.ReverseStringWithRecursion("Recursion rUnnar there");

            Assert.Equal("ereht rannUr noisruceR", result);
        }

        [Fact]
        public void TestReverseStringWithStack()
        {
            string result = reverseStrings.ReverseStringWithStack("Code foo dar");

            Assert.Equal("rad oof edoC", result);
        }

        [Fact]
        public void TestRandomFunctionFalse()
        {
            string result = reverseStrings.ReverseString("They are running");

            Assert.NotEqual("gninur era yeht", result);

            result = reverseStrings.ReverseString("This must be fasle");

            Assert.NotEqual("aslef eb tsum sihT", result);
        }
    }
}
