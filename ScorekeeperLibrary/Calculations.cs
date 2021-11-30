using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary
{/// <summary>
/// Static methods for round and game calculations
/// </summary>
    public static class Calculations
    {
        /// <summary>
        /// Determines the round highest scorer, it has 3 overloads: 2, 3 and 4 players
        /// </summary>
        /// <param name="player1">First Player</param>
        /// <param name="player2">Second Player</param>
        /// <returns>Returns a PlayerModel instance</returns>
        public static PlayerModel DeterminesRoundHighestScorer(PlayerModel player1, PlayerModel player2)
        {
            PlayerModel roundWinner = null;

            roundWinner = ReturnsHighestScorer(player1, player2, player1.RoundScore, player2.RoundScore);

            return roundWinner;
 
        }
        public static PlayerModel DeterminesRoundHighestScorer(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            PlayerModel tempWinner = DeterminesRoundHighestScorer(player1, player2);
            PlayerModel winner = DeterminesRoundHighestScorer(tempWinner, player3);
            return winner;
        }
        public static PlayerModel DeterminesRoundHighestScorer(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            PlayerModel tempWinner = DeterminesRoundHighestScorer(player1, player2, player3);
            PlayerModel winner = DeterminesRoundHighestScorer(tempWinner, player4);
            return winner;
        }

        /// <summary>
        /// Determines the game winner, it has 3 overloads: 2, 3 and 4 players
        /// </summary>
        /// <param name="player1">First Player</param>
        /// <param name="player2">Second Player</param>
        /// <returns></returns>
        public static PlayerModel DeterminesWinner(PlayerModel player1, PlayerModel player2)
        {

            PlayerModel gameWinner = null;
            player1.UpdateRoundSubtotal();
            player2.UpdateRoundSubtotal();

            gameWinner = ReturnsHighestScorer(player1, player2, player1.ScoreSubtotal, player2.ScoreSubtotal);
            return gameWinner;

        }

        public static PlayerModel DeterminesWinner(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            PlayerModel gameWinner = DeterminesWinner(player1, player2);
            gameWinner = DeterminesWinner(gameWinner, player3);
            return gameWinner;
        }

        public static PlayerModel DeterminesWinner(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            PlayerModel tempWinner = DeterminesWinner(player1, player2, player3);
            PlayerModel winner = DeterminesWinner(tempWinner, player4);
            return winner;
        }

        private static PlayerModel ReturnsHighestScorer(PlayerModel player1, PlayerModel player2, int scorePlayer1, int scorePlayer2)
        {
            PlayerModel winner = null;
            if (scorePlayer1 > scorePlayer2)
            {
                winner = player1;
            }
            else
            {
                winner = player2;
            }
            return winner;
        }
        /// <summary>
        /// Takes in as many players' scores as needed and compares the top two scores
        /// </summary>
        /// <param name="playersScores">Scores go into an array that gets sorted</param>
        /// <returns>True if there is a winner or false if the top score is shared by at least two players</returns>
        public static bool IsThereAWinner(params int[] playersScores)
        {
            Array.Sort(playersScores);
            int maxScore = playersScores[playersScores.Length - 1];
            int secondHighestScore = playersScores[playersScores.Length - 2];
            
            if (maxScore != secondHighestScore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void UpdateScoresAllPlayers(GameModel game, IForm form)
        {
            form.UpdatePlayersRoundScores();

            foreach (PlayerModel player in game.Players)
            {
                player.UpdateRoundSubtotal();
            }

            form.UpdateDisplayedSubtotals();

            game.TotalRounds++;

            form.UpdateDisplayedCurrentRound();

            form.ClearDisplayedScores();
        }

        // Not unit tested
        public static PlayerModel ReturnsLowestScorer(PlayerModel player1, PlayerModel player2)
        {
            PlayerModel loser = null;

            if (player1.TotalScore < player2.TotalScore)
            {
                loser = player1;
            }
            else
            {
                loser = player2;
            }
            return loser;
        }
    }
}
