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
        public static PlayerModel DeterminesRoundHighestScorerForTwoPlayerGame(PlayerModel player1, PlayerModel player2)
        {
            PlayerModel roundWinner = null;

            roundWinner = ReturnsHighestScorer(player1, player2, player1.RoundScore, player2.RoundScore);

            return roundWinner;
 
        }
        public static PlayerModel DeterminesRoundHighestScorerForThreePlayerGame(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            PlayerModel tempWinner = DeterminesRoundHighestScorerForTwoPlayerGame(player1, player2);
            PlayerModel winner = DeterminesRoundHighestScorerForTwoPlayerGame(tempWinner, player3);
            return winner;
        }
        public static PlayerModel DeterminesRoundHighestScorerForFourPlayerGame(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            PlayerModel tempWinner = DeterminesRoundHighestScorerForThreePlayerGame(player1, player2, player3);
            PlayerModel winner = DeterminesRoundHighestScorerForTwoPlayerGame(tempWinner, player4);
            return winner;
        }

        // The 3 Methods below determine the winner of the game at any stage
        public static PlayerModel DeterminesWinnerTwoPlayerGame(PlayerModel player1, PlayerModel player2)
        {

            PlayerModel gameWinner = null;
            player1.UpdateRoundSubtotal();
            player2.UpdateRoundSubtotal();

            gameWinner = ReturnsHighestScorer(player1, player2, player1.ScoreSubtotal, player2.ScoreSubtotal);
            return gameWinner;

        }
        public static PlayerModel DeterminesWinnerThreePlayerGame(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            PlayerModel gameWinner = DeterminesWinnerTwoPlayerGame(player1, player2);
            gameWinner = DeterminesWinnerTwoPlayerGame(gameWinner, player3);
            return gameWinner;
        }
        public static PlayerModel DeterminesWinnerFourPlayerGame(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            PlayerModel tempWinner = DeterminesWinnerThreePlayerGame(player1, player2, player3);
            PlayerModel winner = DeterminesWinnerTwoPlayerGame(tempWinner, player4);
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
