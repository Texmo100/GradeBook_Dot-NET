using GradeBook.Helpers;
using System;
using Xunit;

namespace Helpers.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void RegexNumberValidatesCorrectly()
        {
            // Arrange
            var strNumber = "12.12";

            // Act
            var result = strNumber.IsValidNumber();

            // Assert
            Assert.True(result);
        }
    }
}
