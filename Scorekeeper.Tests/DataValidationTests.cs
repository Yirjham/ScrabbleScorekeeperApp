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
        [InlineData("131", false)]
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
        [Theory]
        [InlineData("4","5","3","10", false)]
        [InlineData("","5","3","10", true)]
        [InlineData("4","","3","10", true)]
        [InlineData("4","5","","10", true)]
        [InlineData("4","5","3","", true)]
        [InlineData("","5","3","", true)]
        [InlineData("","","","", true)]
        public void ShouldReturnTrueWhenEmptyStringForFourEntries(string input1, string input2, string input3, string input4, bool expected)
        {
            // Arrange

            // Act 
            bool actual =DataValidation.IsUserEntryEmpty(input1, input2, input3, input4);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
