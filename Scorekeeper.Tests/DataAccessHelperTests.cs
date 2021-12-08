using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsUI;
using Xunit;

namespace Scorekeeper.Tests
{
    public class DataAccessHelperTests
    {
        [Fact]
        public void ShouldReturnDefaultConnectionString()
        {
            // Arrange
            string expected = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SQLPlayersDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //Act
            string actual = DataAccessHelper.GetConnectionString();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnTrueIfPlayerNameAlreadyExist()
        {
            // Arrange
            List<string> playersNames = new List<string>() { "dan", "Pete", "Tom", "LiSa", "sue" };

            PlayerModel player1 = new PlayerModel("Dan");
            PlayerModel player2 = new PlayerModel("Pete");
            PlayerModel player3 = new PlayerModel("toM");
            PlayerModel player4 = new PlayerModel("lisa");
            PlayerModel player5 = new PlayerModel("sue");

            // Act
            bool actual1 = DataAccessHelper.PlayerAlreadyInDB(playersNames, player1);
            bool actual2 = DataAccessHelper.PlayerAlreadyInDB(playersNames, player2);
            bool actual3 = DataAccessHelper.PlayerAlreadyInDB(playersNames, player3);
            bool actual4 = DataAccessHelper.PlayerAlreadyInDB(playersNames, player4);
            bool actual5 = DataAccessHelper.PlayerAlreadyInDB(playersNames, player5);

            //Assert
            Assert.True(actual1);
            Assert.True(actual2);
            Assert.True(actual3);
            Assert.True(actual4);
            Assert.True(actual5);
        }

        [Fact]
        public void ShouldReturnFalseIfPlayerNameIsNotInTheList()
        {
            // Arrange
            List<string> playersNames = new List<string>() { "dan", "Pete", "Tom", "LiSa", "sue" };

            PlayerModel player1 = new PlayerModel("Danny");
            PlayerModel player2 = new PlayerModel("Peter");
            PlayerModel player3 = new PlayerModel("toMhas");
            PlayerModel player4 = new PlayerModel("lis");
            PlayerModel player5 = new PlayerModel("Timmy");

            // Act
            bool actual1 = DataAccessHelper.PlayerAlreadyInDB(playersNames, player1);
            bool actual2 = DataAccessHelper.PlayerAlreadyInDB(playersNames, player2);
            bool actual3 = DataAccessHelper.PlayerAlreadyInDB(playersNames, player3);
            bool actual4 = DataAccessHelper.PlayerAlreadyInDB(playersNames, player4);
            bool actual5 = DataAccessHelper.PlayerAlreadyInDB(playersNames, player5);

            //Assert
            Assert.False(actual1);
            Assert.False(actual2);
            Assert.False(actual3);
            Assert.False(actual4);
            Assert.False(actual5);
        }
    }
}
