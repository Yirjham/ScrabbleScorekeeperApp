using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary
{
    public static class Calculations
    {
        // returns null if the two players have the same round score
        public static PlayerModel DetermineRoundWinnerTwoPlayers(PlayerModel player1, PlayerModel player2)
        {
            PlayerModel roundWinner = null;

            roundWinner = ScoreComparer(player1, player2, player1.RoundScore, player2.RoundScore);

            return roundWinner;
 
        }
        public static PlayerModel DetermineRoundWinnerThreePlayers(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            PlayerModel tempWinner = DetermineRoundWinnerTwoPlayers(player1, player2);
            PlayerModel winner = DetermineRoundWinnerTwoPlayers(tempWinner, player3);
            return winner;
        }
        public static PlayerModel DetermineRoundWinnerFourPlayers(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            PlayerModel tempWinner = DetermineRoundWinnerThreePlayers(player1, player2, player3);
            PlayerModel winner = DetermineRoundWinnerTwoPlayers(tempWinner, player4);
            return winner;
        }
        public static PlayerModel CalculateGameWinnerTwoPlayers(PlayerModel player1, PlayerModel player2)
        {

            PlayerModel gameWinner = null;
            player1.UpdateRoundSubtotal();
            player2.UpdateRoundSubtotal();

            gameWinner = ScoreComparer(player1, player2, player1.ScoreSubtotal, player2.ScoreSubtotal);
            return gameWinner;

        }
        public static PlayerModel CalculateGameWinnerThreePlayers(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            PlayerModel gameWinner = CalculateGameWinnerTwoPlayers(player1, player2);
            gameWinner = CalculateGameWinnerTwoPlayers(gameWinner, player3);
            return gameWinner;
        }
        public static PlayerModel CalculateGameWinnerFourPlayers(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            PlayerModel tempWinner = CalculateGameWinnerThreePlayers(player1, player2, player3);
            PlayerModel winner = CalculateGameWinnerTwoPlayers(tempWinner, player4);
            return winner;
        }


        private static PlayerModel ScoreComparer(PlayerModel player1, PlayerModel player2, int scorePlayer1, int scorePlayer2)
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

    }
}
