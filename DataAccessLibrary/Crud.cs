using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
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

        public List<PlayerMapperModel> LoadAllPlayers()
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

        public PlayerMapperModel ReadPlayer(string playerName)
        {
            PlayerMapperModel output = new PlayerMapperModel();
            string Name = playerName;
            string sqlStatement = "select Id from dbo.Players where Name = @Name";
            int playerID = _dataAccess.LoadData<IdLookUpModel, dynamic>(sqlStatement, new { Name = Name }, _connectionString).FirstOrDefault().Id;

            sqlStatement = "select Id, Name, GamesPlayed, GamesWon, HighestScore " +
                           "from dbo.Players " +
                           "where Id=@Id";
            output = _dataAccess.LoadData<PlayerMapperModel, dynamic>(sqlStatement, new { Id = playerID }, _connectionString).FirstOrDefault();
            return output;
        }

        public void UpdatePlayerName(string newPlayerName, string currentName)
        {
            string sqlStatement = "select Id from dbo.Players where Name = @Name";
            int playerID = _dataAccess.LoadData<IdLookUpModel, dynamic>(sqlStatement, new { Name = currentName },
                _connectionString).FirstOrDefault().Id;

            sqlStatement = "update dbo.Players " +
                            "set Name = @newPlayerName " +
                            "where Id = @Id";
            _dataAccess.SaveData(sqlStatement, new { Name = newPlayerName, Id = playerID }, _connectionString);
        }

        public void UpdatePlayerData(int playerID, PlayerMapperModel player)
        {
                int GamesPlayed = player.GamesPlayed;
                int GamesWon = player.GamesWon;
                int HighestScore = player.HighestScore;
                int Id = player.Id;
                string sqlStatement = "update dbo.Players " +
                                       "set GamesPlayed = @GamesPlayed, GamesWon = @GamesWon, HighestScore = @HighestScore " +
                                       "where Id = @Id";
                _dataAccess.SaveData(sqlStatement, new { GamesPlayed = GamesPlayed, GamesWon = GamesWon, HighestScore = HighestScore, Id = Id }, _connectionString);
        }

        public void DeletePlayer(string playerName)
        {
            string sqlStatement = "select Id from dbo.Players where Name = @Name";
            int playerId = _dataAccess.LoadData<IdLookUpModel, dynamic>(sqlStatement, new { Name = playerName }, _connectionString).First().Id;

            sqlStatement = "delete from dbo.Players where Id = @Id";
            _dataAccess.SaveData(sqlStatement, new { Id = playerId }, _connectionString);
        }
    }
}
