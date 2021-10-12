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
        // The three methods below determine the round highest scorer
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

        // The 3 Methods below determine the winner of the game at any stage
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

    }
}
