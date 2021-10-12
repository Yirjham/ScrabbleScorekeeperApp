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
        PlayerModel player1 = new PlayerModel("Player 1:");
        PlayerModel player2 = new PlayerModel("Player 2:");

        public PlayersNamesWindowTwoPlayers()
        {
            
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RoundFormsTwoPlayers roundForm = new RoundFormsTwoPlayers();
            player1.PlayerName = txtPlayer1.Text;
            player2.PlayerName = txtPlayer2.Text;
            roundForm.Show();
        }
    }
}
