﻿using DataAccessLibrary;
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

        //public static void MapsPlayerForDb(PlayerModel gameWinner)
        //{
        //    PlayerMapperModel player = new PlayerMapperModel();
        //    player.Name = gameWinner.Player
        //}

        public static bool PlayerAlreadyInDB(List<string> playersNames, PlayerModel player)
        {
            foreach (var name in playersNames)
            {
                name.ToLower();
            }

            foreach (var name in playersNames)
            {
                if (name == player.PlayerName.ToLower())
                {
                    return true;
                }
                
            }
            return false;
        }

        public void UpdateExistingPlayerData(List<string> playerNames, PlayerModel player, GameModel game)
        {
            // New code for updating the database with data from new game 
            if (DataAccessHelper.PlayerAlreadyInDB(playerNames, player) == true)
            {
                //Load player by name
                PlayerMapperModel playerDbMapper = _crud.ReadPlayer(player.PlayerName);

                // check if score is higher and add one to games played and won
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
