using DataAccessLibrary.Models;
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
    public class CalculationsTests
    {
        [Fact]
        public void ShouldReturnRoundWinnerForTwoPlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testUser1") { RoundScore = 14 };
            PlayerModel player2 = new PlayerModel("testUser2") { RoundScore = 20 };
            PlayerModel expected = player2;

            // Act
            PlayerModel roundWinner = Calculations.DeterminesRoundHighestScorer(player1, player2);
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
            PlayerModel roundWinner = Calculations.DeterminesRoundHighestScorer(player1, player2, player3);
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
            PlayerModel roundWinner = Calculations.DeterminesRoundHighestScorer(player1, player2, player3, player4);
            PlayerModel actual = roundWinner;

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnTheWinnerOfTheGameAtAnyStageForTwoPlayers()
        {
            // Arrange 
            PlayerModel player1 = new PlayerModel("testUser1") { RoundScore = 0 , ScoreSubtotal = 154};
            PlayerModel player2 = new PlayerModel("testUser2") { RoundScore = 9, ScoreSubtotal = 90 };
           
            PlayerModel expected = player1;

            // Act
            PlayerModel gameWinner = Calculations.DeterminesWinner(player1, player2);
            PlayerModel actual = gameWinner;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldReturnTheWinnerOfTheGameAtAnyStageForThreePlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testUser1") { RoundScore = 13, ScoreSubtotal = 154 };
            PlayerModel player2 = new PlayerModel("testUser2") { RoundScore = 20, ScoreSubtotal = 200 };
            PlayerModel player3 = new PlayerModel("testUser3") { RoundScore = 1, ScoreSubtotal = 218 };
            PlayerModel expected = player2;

            // Act
            PlayerModel gameWinner = Calculations.DeterminesWinner(player1, player2, player3);
            PlayerModel actual = gameWinner;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldReturnTheWinnerOfTheGameAtAnyStageForFourPlayers()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testUser1") { RoundScore = 13, ScoreSubtotal = 154 }; //167
            PlayerModel player2 = new PlayerModel("testUser2") { RoundScore = 20, ScoreSubtotal = 200 }; //220
            PlayerModel player3 = new PlayerModel("testUser3") { RoundScore = 1, ScoreSubtotal = 218 }; //219
            PlayerModel player4 = new PlayerModel("testUser4") { RoundScore = 30, ScoreSubtotal = 191 }; // 221
            PlayerModel expected = player4;

            // Act
            PlayerModel gameWinner = Calculations.DeterminesWinner(player1, player2, player3, player4);
            PlayerModel actual = gameWinner;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnTheLoserForTwoPlayer()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testUser1") { RoundScore = 13, ScoreSubtotal = 154 }; //167
            PlayerModel player2 = new PlayerModel("testUser2") { RoundScore = 20, ScoreSubtotal = 200 }; //220
            player1.UpdateFinalScore();
            player2.UpdateFinalScore();
            List<PlayerModel> expected = new List<PlayerModel>();
            expected.Add(player1);


            // Act
            List<PlayerModel> actual = Calculations.ReturnsLosers(player1, player2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnTheLoserForThreePlayer()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testUser1") { RoundScore = 13, ScoreSubtotal = 154 }; //167 item at index 1
            PlayerModel player2 = new PlayerModel("testUser2") { RoundScore = 20, ScoreSubtotal = 200 }; // winner 220
            PlayerModel player3 = new PlayerModel("testUser3") { RoundScore = 1, ScoreSubtotal = 218 }; //219 item at index 0

            player1.UpdateFinalScore();
            player2.UpdateFinalScore();
            player3.UpdateFinalScore();

            List<PlayerModel> expected = new List<PlayerModel>();
            expected.Add(player3);
            expected.Add(player1);


            // Act
            List<PlayerModel> actual = Calculations.ReturnsLosers(player1, player2, player3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnTheLoserForFourPlayer()
        {
            // Arrange
            PlayerModel player1 = new PlayerModel("testUser1") { RoundScore = 13, ScoreSubtotal = 154 }; // 167, item at index 2
            PlayerModel player2 = new PlayerModel("testUser2") { RoundScore = 20, ScoreSubtotal = 200 }; //220 item at index 0
            PlayerModel player3 = new PlayerModel("testUser3") { RoundScore = 1, ScoreSubtotal = 218 }; // 219 item at index 1
            PlayerModel player4 = new PlayerModel("testUser4") { RoundScore = 30, ScoreSubtotal = 191 }; // winner with 221

            player1.UpdateFinalScore();
            player2.UpdateFinalScore();
            player3.UpdateFinalScore();
            player4.UpdateFinalScore();

            List<PlayerModel> expected = new List<PlayerModel>();
            expected.Add(player2);
            expected.Add(player3);
            expected.Add(player1);


            // Act
            List<PlayerModel> actual = Calculations.ReturnsLosers(player1, player2, player3, player4);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldUpdatePlayersScoreIfHigher()
        {
            //Arrange
            PlayerModel player1 = new PlayerModel("test1") { ScoreSubtotal = 330, RoundScore = 11}; // TotalScore = 341
            PlayerModel player2 = new PlayerModel("test1") { ScoreSubtotal = 245, RoundScore = 5}; // TotalScore = 250
            PlayerModel player3 = new PlayerModel("test1") { ScoreSubtotal = 143, RoundScore = 6}; // TotalScore = 149
            PlayerModel player4 = new PlayerModel("test1") { ScoreSubtotal = 200, RoundScore = 11}; // TotalScore = 211
            PlayerModel player5 = new PlayerModel("test1") { ScoreSubtotal = 167, RoundScore = 4}; // TotalScore = 171

            player1.UpdateFinalScore();
            player2.UpdateFinalScore();
            player3.UpdateFinalScore();
            player4.UpdateFinalScore();
            player5.UpdateFinalScore();

            PlayerMapperModel playerMapper1 = new PlayerMapperModel() { HighestScore = 300 };
            PlayerMapperModel playerMapper2 = new PlayerMapperModel() { HighestScore = 250};
            PlayerMapperModel playerMapper3 = new PlayerMapperModel() { HighestScore = 150 };
            PlayerMapperModel playerMapper4 = new PlayerMapperModel() { HighestScore = 210 };
            PlayerMapperModel playerMapper5 = new PlayerMapperModel() { HighestScore = 80 };

            int expected1 = 341; 
            int expected2 = 250; 
            int expected3 = 150; 
            int expected4 = 211; 
            int expected5 = 171;

            // Act
            Calculations.UpdatePlayerHighestScore(player1, playerMapper1);
            Calculations.UpdatePlayerHighestScore(player2, playerMapper2);
            Calculations.UpdatePlayerHighestScore(player3, playerMapper3);
            Calculations.UpdatePlayerHighestScore(player4, playerMapper4);
            Calculations.UpdatePlayerHighestScore(player5, playerMapper5);

            int actual1 = playerMapper1.HighestScore;
            int actual2 = playerMapper2.HighestScore;
            int actual3 = playerMapper3.HighestScore;
            int actual4 = playerMapper4.HighestScore;
            int actual5 = playerMapper5.HighestScore;

            // Arrange
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected4, actual4);
            Assert.Equal(expected5, actual5);
        }

        [Theory]
        [InlineData(134, 140, 111, 200, true)]
        [InlineData(134, 134, 299, 200, true)]
        [InlineData(0, 23, 320, 320, false)]
        [InlineData(45 , 140, 200, 200, false)]
        [InlineData(200, 140, 200, 201, true)]
        public void ShouldReturnTrueIfThereIsATopScore(int input1, int input2, int input3, int input4, bool expected)
        {
            // Arrange

            // Act 
            bool actual = Calculations.IsThereAWinner(input1, input2, input3, input4);

            // Assert
            Assert.Equal(expected, actual);
        }



    }
}
