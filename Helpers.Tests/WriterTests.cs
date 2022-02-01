using GradeBook.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Helpers.Tests
{
    public class WriterTests
    {
        [Fact]
        public void TheDoubleWriterWorksFine()
        {
            // Arrange
            var writer = new Writer();

            // Act
            var input = writer.DoubleWriter("12.12");

            // Assert
            Assert.Equal(12.12, input);
        }
    }
}
