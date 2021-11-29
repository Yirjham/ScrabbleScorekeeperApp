using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI
{
    public static class DataAccessHelper
    {
        public static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);
            return output;
        }

        //public static void MapsPlayerForDb(PlayerModel gameWinner)
        //{
        //    PlayerMapperModel player = new PlayerMapperModel();
        //    player.Name = gameWinner.Player
        //}

        public static bool PlayerAlreadyInDB(List<string> playersNames, PlayerModel player)
        {
            foreach (var playerName in playersNames)
            {
                if (playerName.ToLower() == player.PlayerName.ToLower())
                {
                    return true;
                }
                
            }
            return false;
        }

    }
}
