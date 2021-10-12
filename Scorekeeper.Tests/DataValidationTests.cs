using ScorekeeperLibrary.DataValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Scorekeeper.Tests
{
    public class DataValidationTests
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("45", false)]
        [InlineData("hello", false)]
        public void ShouldReturnTrueWhenEmptyString(string input, bool expected)
        {
            // Arrange
           
            // Act
            bool actual = DataValidation.isEmpty(input);

            //Assert
            Assert.Equal(expected, actual);
            
        }
        [Theory]
        [InlineData("23", true)]
        [InlineData("0", true)]
        [InlineData("4", true)]
        [InlineData("hello", false)]
        [InlineData("2.1", false)]
        public void ShouldReturnTrueForNumericData(string input, bool expected)
        {
            // Arrange

            // Act
            bool actual = DataValidation.isValidNumericData(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("23", true)]
        [InlineData("0", true)]
        [InlineData("4", true)]
        [InlineData("130", false)]
        [InlineData("-1", false)]
        [InlineData("0.3", false)]
        public void ShouldReturnTrueWhenInValidRange(string input, bool expected)
        {
            // Arrange

            // Act
            bool actual = DataValidation.isValidRange(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
