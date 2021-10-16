using ScorekeeperLibrary;
using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsUI.RoundForms
{
    public static class UIMessages
    {
        // Round highest scorer messages for 2, 3 and 4 players
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

        // Game winner messages for 2, 3 and 4 players
        public static string GameWinnerMessage(GameModel game, PlayerModel player1, PlayerModel player2)
        {
            PlayerModel winner = Calculations.DeterminesWinner(player1, player2);
            return $"After { game.TotalRounds } rounds the winner is { winner.PlayerName } with " +
                        $"{ game.GameWinner.ScoreSubtotal } points. Congratulations!!!";
        }
        public static string GameWinnerMessage(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            PlayerModel winner = Calculations.DeterminesWinner(player1, player2, player3);
            return $"{ winner.PlayerName } is today's winner. Congratulations!!!";
        }
        public static string GameWinnerMessage(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            PlayerModel winner = Calculations.DeterminesWinner(player1, player2, player3, player4);
            return $"{ winner.PlayerName } is today's winner. Congratulations!!!";
        }
    }


}
