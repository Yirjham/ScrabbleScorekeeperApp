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
        [InlineData("23", true)]
        [InlineData("0", true)]
        [InlineData("4", true)]
        [InlineData("131", false)]
        [InlineData("-1", false)]
        [InlineData("0.3", true)] //valid range but invalid type
        public void ShouldReturnTrueWhenInValidRangeOldMethod(string input, bool expected)
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
        [InlineData("","5","3","", true)]
        [InlineData("","","","", true)]
        [InlineData("","","","5", true)]
        [InlineData("","3","","5", true)]
        [InlineData("4","","","5", true)]
        [InlineData("4","3","4","5", false)]
        public void ShouldReturnTrueWhenEmptyStringForFourEntries(string input1, string input2, string input3, string input4, bool expected)
        {
            // Arrange
            // Act 
            bool actualFourEntries = DataValidation.IsUserEntryEmpty(input1, input2, input3, input4);
            bool actualThreeEntries = DataValidation.IsUserEntryEmpty(input1, input2, input3);

            // Assert
            Assert.Equal(expected, actualFourEntries);
            Assert.Equal(expected, actualThreeEntries);
        }
        [Theory]
        [InlineData("4","65","0","43", true)]
        [InlineData("4r","65","0","43", false)]
        [InlineData("4","f","0","43", false)]
        [InlineData("4","65","0","/", false)]
        [InlineData("4","65","","43", false)]
        [InlineData("0", "0", "0", "0", true)]
        public void ShouldReturnTrueWhenValidParseFourEntries(string input1, string input2, string input3, string input4, bool expected)
        {
            // Arrange
            // Act
            bool actual = DataValidation.isValidNumber(input1, input2, input3, input4);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4", "65", true)]
        [InlineData("4r", "65", false)]
        [InlineData("4", "f", false)]
        [InlineData("", "65", false)]
        [InlineData("4", "", false)]
        [InlineData("0", "0", true)]
        [InlineData("100", "4", true)]
        public void ShouldReturnTrueWhenValidParseTwoEntries(string input1, string input2, bool expected)
        {
            // Arrange
            // Act
            bool actual = DataValidation.isValidNumber(input1, input2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4", "65", "0", "43", true)]
        [InlineData("0", "130", "35", "43", true)]
        [InlineData("-1", "5", "0", "43", false)]
        [InlineData("131", "65", "98", "65", false)]
        [InlineData("5", "65", "131", "43", false)]
        [InlineData("0", "0", "0", "0", true)]
        public void ShouldReturnTrueWhenInValidRange(string input1, string input2, string input3, string input4, bool expected)
        {
            // Arrange
            // Act
            bool actual = DataValidation.isValidRange(input1, input2, input3, input4);

            // Asseert
            Assert.Equal(expected, actual);
        }
    }
}
