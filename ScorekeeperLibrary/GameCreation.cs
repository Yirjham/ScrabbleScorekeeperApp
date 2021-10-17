using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary
{
    public static class GameCreation
    {
        public static List<PlayerModel> CreatePlayers(GameModel game, params string[] names)
        {
            PlayerModel player1 = new PlayerModel("");
            PlayerModel player2 = new PlayerModel("");
            PlayerModel player3 = new PlayerModel("");
            PlayerModel player4 = new PlayerModel("");
            List<PlayerModel> players = new List<PlayerModel>();

            switch (names.Length)
            {
                case 2:
                    player1.PlayerName = names[0];
                    player2.PlayerName = names[1];

                    players.Add(player1);
                    players.Add(player2);
                    break;
                case 3:
                    player1.PlayerName = names[0];
                    player2.PlayerName = names[1];
                    player3.PlayerName = names[2];

                    players.Add(player1);
                    players.Add(player2);
                    players.Add(player3);
                    break;
                case 4:
                    player1.PlayerName = names[0];
                    player2.PlayerName = names[1];
                    player3.PlayerName = names[2];
                    player4.PlayerName = names[3];

                    players.Add(player1);
                    players.Add(player2);
                    players.Add(player3);
                    players.Add(player4);
                    break;
                default:
                    break;
            }

            return players;
        }
    }
}
