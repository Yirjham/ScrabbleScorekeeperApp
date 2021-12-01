﻿using ScorekeeperLibrary;
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



    }
}
