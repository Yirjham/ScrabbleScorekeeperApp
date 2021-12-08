using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary.Models
{
    public static class UIMessages
    {
        public static string RoundHighestScorerMessage(PlayerModel player1, PlayerModel player2)   
        {
            PlayerModel highestScorer = Calculations.DeterminesRoundHighestScorer(player1, player2);
            return $"{highestScorer.PlayerName} is the round highest scorer with {highestScorer.RoundScore} points. Well done!";
        }

        public static string RoundHighestScorerMessage(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            PlayerModel highestScorer = Calculations.DeterminesRoundHighestScorer(player1, player2, player3);
            return $"{highestScorer.PlayerName} is the round highest scorer with {highestScorer.RoundScore} points. Well done!";
        }

        public static string RoundHighestScorerMessage(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            PlayerModel highestScorer = Calculations.DeterminesRoundHighestScorer(player1, player2, player3, player4);
            return $"{highestScorer.PlayerName} is the round highest scorer with {highestScorer.RoundScore} points. Well done!";
        }
        
        public static string GameWinnerMessage(GameModel game, PlayerModel player1, PlayerModel player2) // not unit tested
        {
            PlayerModel winner = Calculations.DeterminesWinner(player1, player2);
            return $"After { game.TotalRounds } rounds the winner is { winner.PlayerName } with " +
                        $"{ game.GameWinner.TotalScore } points. Congratulations!!!";
        }

        public static string GameWinnerMessage(GameModel game, PlayerModel player1, PlayerModel player2, PlayerModel player3) // not unit tested
        {
            PlayerModel winner = Calculations.DeterminesWinner(player1, player2, player3);
            return $"After { game.TotalRounds } rounds the winner is { winner.PlayerName } with " +
                        $"{ game.GameWinner.TotalScore } points. Congratulations!!!";
        }
      
        public static string GameWinnerMessage(GameModel game, PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            PlayerModel winner = Calculations.DeterminesWinner(player1, player2, player3, player4);
            return $"After { game.TotalRounds } rounds the winner is { winner.PlayerName } with " +
                        $"{ game.GameWinner.TotalScore } points. Congratulations!!!";
        }
    }
}
