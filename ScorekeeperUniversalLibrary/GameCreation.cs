using ScorekeeperUniversalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperUniversalLibrary
{
    public class GameCreation
    {
        /// <summary>
        /// Creates an array with empty names and then adds the names sequentially
        /// </summary>
        /// <param name="game">The actual game created</param>
        /// <param name="names">The names of all the players</param>
        /// <returns>An array with all the players that needs to be conversed to a List</returns>
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
        }
    }
}
