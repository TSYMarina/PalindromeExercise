using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("civic", true)]
        [InlineData("word", false)]
        [InlineData("Madam", true)]
        [InlineData("radar", true)]
        [InlineData("backwards", false)]

        public void Test1(string word, bool expected)
        {
            //Arrange:
            var tester = new WordSmith();
            //Act:
            var actual = tester.IsAPalindrome(word);
            //Assert:
            Assert.Equal(expected, actual);

        }
    }
}
