using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScorekeeperLibrary;
using ScorekeeperLibrary.Models;
using WinFormsUI.RoundForms;

namespace WinFormsUI
{
    public partial class PlayersNamesWindowTwoPlayers : Form
    {
        public PlayersNamesWindowTwoPlayers()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string namePlayer1 = txtPlayer1.Text;
            string namePlayer2 = txtPlayer2.Text;
            PlayerModel player1 = new PlayerModel(namePlayer1);
            PlayerModel player2 = new PlayerModel(namePlayer2);
            GameModel game = new GameModel();
            game.Players.Add(player1);
            game.Players.Add(player2);
            
            RoundFormsTwoPlayers roundForm = new RoundFormsTwoPlayers(game);
            roundForm.Show();
        }
    }
}
