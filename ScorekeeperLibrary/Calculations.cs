using DataAccessLibrary.Models;
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
        
        public static List<PlayerModel> ReturnsLosers(PlayerModel player1, PlayerModel player2)
        {
            List<PlayerModel> allPlayers = new List<PlayerModel> { player1, player2};

            allPlayers = allPlayers.OrderByDescending(t => t.TotalScore).ToList();
            allPlayers.RemoveAt(0); // Removes winner from list
            List<PlayerModel> losers = allPlayers;

            return losers;
        }

        public static List<PlayerModel> ReturnsLosers(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            List<PlayerModel> allPlayers = new List<PlayerModel> { player1, player2, player3 };

            allPlayers = allPlayers.OrderByDescending(t => t.TotalScore).ToList();
            allPlayers.RemoveAt(0); // Removes winner from list
            List<PlayerModel> losers = allPlayers;

            return losers;
        }

        public static List<PlayerModel> ReturnsLosers(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            List<PlayerModel> allPlayers = new List<PlayerModel> { player1, player2, player3, player4 };

            allPlayers = allPlayers.OrderByDescending(t => t.TotalScore).ToList();
            allPlayers.RemoveAt(0); // Removes winner from list
            List<PlayerModel> losers = allPlayers;

            return losers;
        }
        
        public static void UpdatePlayerHighestScore(PlayerModel player, PlayerMapperModel playerDbMapper)
        {
            if (player.TotalScore > playerDbMapper.HighestScore)
            {
                playerDbMapper.HighestScore = player.TotalScore;
            }
        }
    }
}
