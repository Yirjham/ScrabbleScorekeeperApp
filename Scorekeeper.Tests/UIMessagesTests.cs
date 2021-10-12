using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Scorekeeper.Tests
{
    public class UIMessagesTests
    {
        [Fact]
        public void ShouldReturnMessageForHighestScorerForTwoPlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testPlayer1") { RoundScore = 9 };
            PlayerModel player2 = new PlayerModel("testPlayer2") { RoundScore = 4 };
            string expected = "testPlayer1 is the round highest scorer with 9 points. Well done!";

            //Act 
            string actual = UIMessages.RoundHighestScorerMessage(player1, player2);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnMessageForHighestScorerForThreePlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testPlayer1") { RoundScore = 16 };
            PlayerModel player2 = new PlayerModel("testPlayer2") { RoundScore = 30 };
            PlayerModel player3 = new PlayerModel("testPlayer3") { RoundScore = 0 };
            string expected = "testPlayer2 is the round highest scorer with 30 points. Well done!";

            //Act 
            string actual = UIMessages.RoundHighestScorerMessage(player1, player2, player3);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnMessageForHighestScorerForFourPlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testPlayer1") { RoundScore = 1 };
            PlayerModel player2 = new PlayerModel("testPlayer2") { RoundScore = 5 };
            PlayerModel player3 = new PlayerModel("testPlayer3") { RoundScore = 3 };
            PlayerModel player4 = new PlayerModel("testPlayer4") { RoundScore = 6 };
            string expected = "testPlayer4 is the round highest scorer with 6 points. Well done!";

            //Act 
            string actual = UIMessages.RoundHighestScorerMessage(player1, player2, player3, player4);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnMessageForWinnerForTwoPlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testPlayer1") { RoundScore = 15, ScoreSubtotal = 134 }; //149
            PlayerModel player2 = new PlayerModel("testPlayer2") { RoundScore = 0, ScoreSubtotal = 150 }; //150
            string expected = "testPlayer2 is today's winner. Congratulations!!!";

            // Act
            string actual = UIMessages.GameWinnerMessage(player1, player2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnMessageForWinnerForThreePlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testPlayer1") { RoundScore = 15, ScoreSubtotal = 134 }; //149
            PlayerModel player2 = new PlayerModel("testPlayer2") { RoundScore = 0, ScoreSubtotal = 150 }; //150
            PlayerModel player3 = new PlayerModel("testPlayer3") { RoundScore = 10, ScoreSubtotal = 141 }; //151
            string expected = "testPlayer3 is today's winner. Congratulations!!!";

            // Act
            string actual = UIMessages.GameWinnerMessage(player1, player2, player3);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldReturnMessageForWinnerForFourPlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testPlayer1") { RoundScore = 15, ScoreSubtotal = 175 }; //190
            PlayerModel player2 = new PlayerModel("testPlayer2") { RoundScore = 0, ScoreSubtotal = 150 }; //150
            PlayerModel player4 = new PlayerModel("testPlayer4") { RoundScore = 1, ScoreSubtotal = 100 }; //101
            PlayerModel player3 = new PlayerModel("testPlayer3") { RoundScore = 10, ScoreSubtotal = 141 }; //151
            string expected = "testPlayer1 is today's winner. Congratulations!!!";

            // Act
            string actual = UIMessages.GameWinnerMessage(player1, player2, player3, player4);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
