using CSharp_challenges.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpChallenges
{
    public class FindDuplicatesTest
    {
        FindDuplicates findDuplicates = new FindDuplicates();

        [Fact]
        public void FindDuplicateCharacters_ShouldReturnDuplicates_WhenInputHasDuplicates()
        {
            // Arrange
            List<string> input = new List<string> { "a", "b", "c", "a", "d", "b" };
            List<string> expected = new List<string> { "a", "b" };
            // Act
            List<string> result = findDuplicates.FindDuplicateCharacters(input);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindDuplicateCharacters_ShouldReturnEmptyList_WhenInputHasNoDuplicates()
        {
            // Arrange
            List<string> input = new List<string> { "a", "b", "c", "d" };
            List<string> expected = new List<string>();
            // Act
            List<string> result = findDuplicates.FindDuplicateCharacters(input);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
