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
        public void DetermineRoundWinnerForTwoPlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testUser1") { RoundScore = 14 };
            PlayerModel player2 = new PlayerModel("testUser2") { RoundScore = 20 };
            PlayerModel expected = player2;

            // Act
            PlayerModel roundWinner = Calculations.DetermineRoundWinnerTwoPlayers(player1, player2);
            PlayerModel actual = roundWinner;

            // Assert 
            Assert.Equal(expected, actual);

        }
        
        
    }
}
