using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.RoundForms;

namespace WinFormsUI
{
    public static class GameHelper
    {
        public static void InitialiseFourPlayerForm(GameModel game)
        {
            RoundFormsFourPlayers roundForm = new RoundFormsFourPlayers(game);
            roundForm.Show();
        }
        public static void InitialiseThreePlayerForm(GameModel game)
        {
            RoundFormsThreePlayers roundForm = new RoundFormsThreePlayers(game);
            roundForm.Show();
        }
        public static void InitialiseTwoPlayerForm(GameModel game)
        {
            RoundFormsTwoPlayers roundForm = new RoundFormsTwoPlayers(game);
            roundForm.Show();
        }
        public static GameModel CreateGame(PlayerModel player1, PlayerModel player2)
        {
            GameModel game = new GameModel();
            AddPlayersToGame(game, player1, player2);
            return game;
        }
        public static GameModel CreateGame(PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            GameModel game = new GameModel();
            AddPlayersToGame(game, player1, player2, player3);
            return game;
        }
        public static GameModel CreateGame(PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            GameModel game = new GameModel();
            AddPlayersToGame(game, player1, player2, player3, player4);
            return game;
        }
        public static (PlayerModel, PlayerModel) CreatePlayers(string player1Name, string player2Name)
        {
            PlayerModel player1 = new PlayerModel(player1Name);
            PlayerModel player2 = new PlayerModel(player2Name);
            return (player1, player2);
        }
        public static (PlayerModel, PlayerModel, PlayerModel) CreatePlayers(string player1Name, string player2Name, string player3Name)
        {
            PlayerModel player1 = new PlayerModel(player1Name);
            PlayerModel player2 = new PlayerModel(player2Name);
            PlayerModel player3 = new PlayerModel(player3Name);
            return (player1, player2, player3);
        }
        public static (PlayerModel, PlayerModel, PlayerModel, PlayerModel) CreatePlayers(string player1Name, string player2Name, string player3Name, string player4Name)
        {
            PlayerModel player1 = new PlayerModel(player1Name);
            PlayerModel player2 = new PlayerModel(player2Name);
            PlayerModel player3 = new PlayerModel(player3Name);
            PlayerModel player4 = new PlayerModel(player4Name);
            return (player1, player2, player3, player4);
        }

        private static void AddPlayersToGame(GameModel game, PlayerModel player1, PlayerModel player2)
        {
            game.Players = new List<PlayerModel> { player1, player2 };
        }
        private static void AddPlayersToGame(GameModel game, PlayerModel player1, PlayerModel player2, PlayerModel player3)
        {
            game.Players = new List<PlayerModel> { player1, player2, player3 };

        }
        private static void AddPlayersToGame(GameModel game, PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4)
        {
            game.Players = new List<PlayerModel> { player1, player2, player3, player4 };
        }
    }
}
