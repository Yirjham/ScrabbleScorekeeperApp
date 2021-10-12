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
        public void ShouldReturnRoundWinnerForTwoPlayers()
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
        [Fact]
        public void ShouldReturnRoundWinnerForThreePlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testUser1") { RoundScore = 13 };
            PlayerModel player2 = new PlayerModel("testUser2") { RoundScore = 2 };
            PlayerModel player3 = new PlayerModel("testUser3") { RoundScore = 7 };
            PlayerModel expected = player1;

            // Act
            PlayerModel roundWinner = Calculations.DetermineRoundWinnerThreePlayers(player1, player2, player3);
            PlayerModel actual = roundWinner;

            // Assert

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ShouldReturnRoundWinnerForFourPlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testUser1") { RoundScore = 2 };
            PlayerModel player2 = new PlayerModel("testUser2") { RoundScore = 5 };
            PlayerModel player3 = new PlayerModel("testUser3") { RoundScore = 0 };
            PlayerModel player4 = new PlayerModel("testUser4") { RoundScore = 15 };
            PlayerModel expected = player4;

            // Act
            PlayerModel roundWinner = Calculations.DetermineRoundWinnerFourPlayers(player1, player2, player3, player4);
            PlayerModel actual = roundWinner;

            // Assert

            Assert.Equal(expected, actual);

        }


    }
}
