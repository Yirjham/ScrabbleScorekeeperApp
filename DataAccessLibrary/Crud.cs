﻿using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class Crud
    {
        private readonly string _connectionString;
        private SqlDataAccess _dataAccess = new SqlDataAccess();

        public Crud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<PlayerMapperModel> ReadAllPlayers()
        {
            string sqlStatement = "select Id, Name, GamesPlayed, GamesWon, HighestScore from dbo.Players";

            return _dataAccess.LoadData<PlayerMapperModel, dynamic>(sqlStatement, new { }, _connectionString);
        }

        public void CreatePlayer(PlayerMapperModel player)
        {
            string sqlStatement = "insert into dbo.Players (Name, GamesPlayed, GamesWon, HighestScore) " +
                "values (@Name, @GamesPlayed, @GamesWon, @HighestScore)";
            _dataAccess.SaveData(sqlStatement, new { player.Name, player.GamesPlayed, player.GamesWon, player.HighestScore }, _connectionString);
        }

        public void UpdatePlayerName(string newPlayerName, string currentName)
        {
            // Get ID by using Name
            string sqlStatement = "select Id from dbo.Players where Name = @Name";
            int playerID = _dataAccess.LoadData<IdLookUpModel, dynamic>(sqlStatement, new {Name = currentName}, _connectionString).First().Id;

            // Update Name by using ID
            sqlStatement = "update dbo.Players set Name = @newPlayerName where Id = @Id";


            // Update using Dapper based method
            _dataAccess.SaveData(sqlStatement, new { Name = newPlayerName, Id = playerID }, _connectionString);
        }

        public void DeletePlayer(string playerName)
        {
            // Get id with the player's name
            string sqlStatement = "select Id from dbo.Players where Name = @Name";
            int playerId = _dataAccess.LoadData<IdLookUpModel, dynamic>(sqlStatement, new { Name = playerName }, _connectionString).First().Id;

            // Use id to delete player's row in db
            sqlStatement = "delete from dbo.Players where Id = @Id";
            _dataAccess.SaveData(sqlStatement, new {Id = playerId}, _connectionString);
        }
    }
}
