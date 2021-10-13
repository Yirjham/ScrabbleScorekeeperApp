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
            txtPlayer3.ReadOnly = true;
            txtPlayer4.ReadOnly = true;

        }

        private void btnEnter_Click(object sender, EventArgs e)
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
        private void groupBoxInitialForm_Enter(object sender, EventArgs e)
        {
            //if (rbtnTwoPlayers.Checked == true)
            //{
            //    txtPlayer1.ReadOnly = false;
            //    txtPlayer2.ReadOnly = false;
            //    txtPlayer3.ReadOnly = true;
            //    txtPlayer4.ReadOnly = true;
            //}
            //else if (rbtnThreePlayers.Checked == true)
            //{
            //    txtPlayer1.ReadOnly = false;
            //    txtPlayer2.ReadOnly = false;
            //    txtPlayer3.ReadOnly = false;
            //    txtPlayer4.ReadOnly = true;
            //}
            //else if (rbtnFourPlayers.Checked == true)
            //{
            //    txtPlayer1.ReadOnly = false;
            //    txtPlayer2.ReadOnly = false;
            //    txtPlayer3.ReadOnly = false;
            //    txtPlayer4.ReadOnly = false;
            //}
        }
    }
}
