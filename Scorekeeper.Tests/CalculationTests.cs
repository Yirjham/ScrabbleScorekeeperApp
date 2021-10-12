using ScorekeeperLibrary;
using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Scorekeeper.Tests
{
    public class CalculationTests
    {
        [Fact]
        public void ShouldAddUpTwoScores()
        {
            // Arrange
            PlayerModel player = new PlayerModel("testUser") { ScoreSubtotal = 100 };
            player.RoundScore = 24;
            int expected = 124;

            // Act
            Calculations.CalculateCurrentScore(player, player.RoundScore);
            int actual = player.ScoreSubtotal;
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
