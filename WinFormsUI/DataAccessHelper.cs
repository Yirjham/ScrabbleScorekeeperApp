using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using ScorekeeperLibrary;
using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI
{
    public class DataAccessHelper
    {
        private readonly Crud _crud;

        public DataAccessHelper(Crud crud)
        {
            _crud = crud;
        }

        public static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);
            return output;
        }

        public static bool PlayerAlreadyInDB(List<string> playersNames, PlayerModel player)
        {  
            foreach (var name in playersNames)
            {
                if (name.ToLower() == player.PlayerName.ToLower())
                {
                    return true;
                }

            }
            return false;
        }

        // Needs mocking
        public void UpdateExistingPlayerData(List<string> playerNames, PlayerModel player, GameModel game)
        {
            if (DataAccessHelper.PlayerAlreadyInDB(playerNames, player) == true)
            {
                PlayerMapperModel playerDbMapper = _crud.ReadPlayer(player.PlayerName);

                if (playerDbMapper != null)
                {
                    playerDbMapper.GamesPlayed++;

                    if (game.GameWinner.PlayerName.ToLower() == playerDbMapper.Name.ToLower())
                    {
                        playerDbMapper.GamesWon++;
                    }

                    Calculations.UpdatePlayerHighestScore(player, playerDbMapper);
                }
                _crud.UpdatePlayerData(playerDbMapper.Id, playerDbMapper);
            }
        }

      // Needs mocking 
        public void AddNewPlayerToDb(PlayerModel player, bool isWinner)
        {
            PlayerMapperModel playerDbMapper = new PlayerMapperModel();

            playerDbMapper.Name = player.PlayerName;
            playerDbMapper.GamesPlayed = 1;

            if (isWinner ==  true)
            {
                playerDbMapper.GamesWon++;
            }
            else
            {
                playerDbMapper.GamesWon = 0;
            }

            playerDbMapper.HighestScore = player.TotalScore;

            _crud.CreatePlayer(playerDbMapper);
        }
    }
}
