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
        public static PlayerModel[] CreatePlayers(GameModel game, params string[] names)
        {
            PlayerModel[] players = new PlayerModel[names.Length];

            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new PlayerModel("");
            }
            
            int j = 0;
            foreach (string name in names)
            {
                players[j].PlayerName = name;
                j++;
            }

            return players;
            
            
            
            
            
            
            //List<PlayerModel> players = new List<PlayerModel>();
            
            //switch (names.Length)
            //{
            //    case 2:
            //        players = new List<PlayerModel>() { new PlayerModel(""), new PlayerModel("") };
            //        int i = 0;
            //        foreach (PlayerModel player in players)
            //        {
            //            player.PlayerName = names[i];
            //            i++;
            //        }
            //        break;
            //    case 3:
            //        players = new List<PlayerModel>() { new PlayerModel(""), new PlayerModel(""), new PlayerModel("") };
            //        i = 0;
            //        foreach (PlayerModel player in players)
            //        {
            //            player.PlayerName = names[i];
            //            i++;
            //        }
            //        break;
            //    case 4:
            //        players = new List<PlayerModel>() { new PlayerModel(""), new PlayerModel(""), new PlayerModel(""), new PlayerModel("") };
            //        i = 0;
            //        foreach (PlayerModel player in players)
            //        {
            //            player.PlayerName = names[i];
            //            i++;
            //        }
            //        break;
            //    default:
            //        break;
            //}
            //return players;




            //    PlayerModel player1 = new PlayerModel("");
            //    PlayerModel player2 = new PlayerModel("");
            //    PlayerModel player3 = new PlayerModel("");
            //    PlayerModel player4 = new PlayerModel("");
            //    List<PlayerModel> players = new List<PlayerModel>();

            //    switch (names.Length)
            //    {
            //        case 2:
            //            player1.PlayerName = names[0];
            //            player2.PlayerName = names[1];

            //            players.Add(player1);
            //            players.Add(player2);
            //            break;
            //        case 3:
            //            player1.PlayerName = names[0];
            //            player2.PlayerName = names[1];
            //            player3.PlayerName = names[2];

            //            players.Add(player1);
            //            players.Add(player2);
            //            players.Add(player3);
            //            break;
            //        case 4:
            //            player1.PlayerName = names[0];
            //            player2.PlayerName = names[1];
            //            player3.PlayerName = names[2];
            //            player4.PlayerName = names[3];

            //            players.Add(player1);
            //            players.Add(player2);
            //            players.Add(player3);
            //            players.Add(player4);
            //            break;
            //        default:
            //            break;
            //    }

            //    return players;
            //}
        }
    }
}
