using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Scorekeeper.Tests
{
    public class ModelsTests
    {
        [Theory]
        [InlineData(20,80,100)]
        [InlineData(0,80,80)]
        [InlineData(66,0,66)]
        [InlineData(0,0,0)]
        public void ShouldReturnGameTotal(int roundScore, int subtotal, int expected)
        {
            // Arrange
            PlayerModel player = new PlayerModel("yir");
            player.ScoreSubtotal = subtotal;
            player.RoundScore = roundScore;
           

            // Act
            player.UpdateFinalScore();
            int actual = player.TotalScore;

            // Assert

            Assert.Equal(expected, actual);
        }


    }
}
