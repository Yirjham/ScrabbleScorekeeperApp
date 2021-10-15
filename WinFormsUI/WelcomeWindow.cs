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
    public partial class frmWelcomeWindow : Form
    {
        public frmWelcomeWindow()
        {
            InitializeComponent();
            DefaultToTwoPlayerOption();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (rbtnTwoPlayers.Checked == true)
            {
                (PlayerModel player1, PlayerModel player2) players = GameHelper.CreatePlayers(txtPlayer1.Text, txtPlayer2.Text);
                GameModel game = GameHelper.CreateGame(players.player1, players.player2);
                GameHelper.InitialiseTwoPlayerForm(game);
            }
            else if (rbtnThreePlayers.Checked == true)
            {
                (PlayerModel player1, PlayerModel player2, PlayerModel player3) players = GameHelper.CreatePlayers(txtPlayer1.Text, txtPlayer2.Text, txtPlayer3.Text);
                GameModel game = GameHelper.CreateGame(players.player1, players.player2, players.player3);
                GameHelper.InitialiseThreePlayerForm(game);
            }
            else if (rbtnFourPlayers.Checked == true)
            {
                (PlayerModel player1, PlayerModel player2, PlayerModel player3, PlayerModel player4) players = GameHelper.CreatePlayers(txtPlayer1.Text, txtPlayer2.Text, txtPlayer3.Text, txtPlayer4.Text);
                GameModel game = GameHelper.CreateGame(players.player1, players.player2, players.player3, players.player4);
                GameHelper.InitialiseFourPlayerForm(game);
            }
        }
        private void DefaultToTwoPlayerOption()
        {
            txtPlayer3.ReadOnly = true;
            txtPlayer4.ReadOnly = true;
        }

        private void rbtnThreePlayers_CheckedChanged(object sender, EventArgs e)
        {
            txtPlayer1.ReadOnly = false;
            txtPlayer2.ReadOnly = false;
            txtPlayer3.ReadOnly = false;
            txtPlayer4.ReadOnly = true;
        }

        private void rbtnFourPlayers_CheckedChanged(object sender, EventArgs e)
        {
            txtPlayer1.ReadOnly = false;
            txtPlayer2.ReadOnly = false;
            txtPlayer3.ReadOnly = false;
            txtPlayer4.ReadOnly = false;
        }

        private void rbtnTwoPlayers_CheckedChanged(object sender, EventArgs e)
        {
            txtPlayer1.ReadOnly = false;
            txtPlayer2.ReadOnly = false;
            txtPlayer3.ReadOnly = true;
            txtPlayer4.ReadOnly = true;
        }
    }
}
