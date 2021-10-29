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
        /// <summary>
        /// Creates an array of players with initial empty names and then adds the names sequentially
        /// </summary>
        /// <param name="game">The actual game created</param>
        /// <param name="names">The names of all the players</param>
        /// <returns>An array with all the players</returns>
        public static PlayerModel[] CreatePlayers(params string[] names)
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
