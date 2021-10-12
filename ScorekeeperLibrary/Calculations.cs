﻿using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary
{
    public static class Calculations
    {
        public static PlayerModel DetermineRoundWinnerTwoPlayers(PlayerModel player, PlayerModel anotherPlayer)
        {
            PlayerModel roundWinner = null;
            if (player.RoundScore > anotherPlayer.RoundScore)
            {
                roundWinner = player;
            }
            else
            {
                roundWinner = anotherPlayer;
            }
            return roundWinner;
        }
        public static PlayerModel DetermineRoundWinnerThreePlayers(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            PlayerModel winner = DetermineRoundWinnerTwoPlayers(player1, player2);
            winner = DetermineRoundWinnerTwoPlayers(winner, player3);
            return winner;
        }
        public static PlayerModel DetermineRoundWinnerFourPlayers(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            throw new NotImplementedException();
        }

    }
}
