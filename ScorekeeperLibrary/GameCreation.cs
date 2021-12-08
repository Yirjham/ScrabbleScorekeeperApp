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
        public static PlayerModel[] CreatePlayers(params string[] names) //not unit tested
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
        }
    }
}
