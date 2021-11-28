using DataAccessLibrary.Models;
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

            return _dataAccess.LoadData<PlayerMapperModel, dynamic>(sql, new { }, _connectionString);
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

            // Update Name by using ID
            string sqlStatement = "update dbo.Players set Name = @NewName where Name = @CurrentName";

            // Update using Dapper

           
        }
    }
}
