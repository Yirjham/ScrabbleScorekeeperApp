using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Scorekeeper.Tests
{
    public class PlayerModelTests
    {
        [Fact]
        public void UpdataPlayerCurrentScore()
        {
            // Arrange
            PlayerModel player = new PlayerModel("testUser") 
            { 
                ScoreSubtotal = 100, 
                RoundScore = 24 
            };
            int expected = 124;

            // Act
            player.UpdateRoundSubtotal();
            int actual = player.ScoreSubtotal;

            // Assert
            Assert.Equal(expected, actual);
            
        }
    }
}
