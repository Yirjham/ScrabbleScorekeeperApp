using DataAccessLibrary;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI.SeedData
{
    public class SeedData
    {
        private readonly Crud _crud;

        public SeedData()
        {
            _crud = new Crud(DataAccessHelper.GetConnectionString());
        }

        internal void InitialiseDatabase()
        {
            if (_crud.LoadAllPlayers().Any())
            {
                return;
            }

            List<PlayerMapperModel> seedDataList = new List<PlayerMapperModel>() { 
                new PlayerMapperModel() { Name = "Ray", GamesWon = 3, GamesPlayed = 5, HighestScore = 198 }, 
                new PlayerMapperModel() { Name = "Jodi", GamesWon = 6, GamesPlayed = 9, HighestScore = 210 }, 
                new PlayerMapperModel() { Name = "Jessica", GamesWon = 2, GamesPlayed = 6, HighestScore = 259 }, 
                new PlayerMapperModel() { Name = "Jon", GamesWon = 4, GamesPlayed = 6, HighestScore = 198 }, 
                new PlayerMapperModel() { Name = "Arthur", GamesWon = 6, GamesPlayed = 7, HighestScore = 330 }, 
                new PlayerMapperModel() { Name = "Eva", GamesWon = 5, GamesPlayed = 10, HighestScore = 248 }, 
                new PlayerMapperModel() { Name = "Zoe", GamesWon = 2, GamesPlayed = 6, HighestScore = 218 }, 
                new PlayerMapperModel() { Name = "Max", GamesWon = 1, GamesPlayed = 2, HighestScore = 299 }, 
                new PlayerMapperModel() { Name = "Amy", GamesWon = 0, GamesPlayed = 1, HighestScore = 204 }, 
                new PlayerMapperModel() { Name = "Ian", GamesWon = 1, GamesPlayed = 7, HighestScore = 213 } 
            };

            _crud.CreatePlayer(seedDataList[0]);
            _crud.CreatePlayer(seedDataList[1]);
            _crud.CreatePlayer(seedDataList[2]);
            _crud.CreatePlayer(seedDataList[3]);
            _crud.CreatePlayer(seedDataList[4]);
            _crud.CreatePlayer(seedDataList[5]);
            _crud.CreatePlayer(seedDataList[6]);
            _crud.CreatePlayer(seedDataList[7]);
            _crud.CreatePlayer(seedDataList[8]);
            _crud.CreatePlayer(seedDataList[9]);
        }
    }
}
