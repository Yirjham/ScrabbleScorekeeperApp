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

            if (rbtnTwoPlayers.Checked == true)
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
            else if (rbtnThreePlayers.Checked == true)
            {
                string namePlayer1 = txtPlayer1.Text;
                string namePlayer2 = txtPlayer2.Text;
                string namePlayer3 = txtPlayer3.Text;
                PlayerModel player1 = new PlayerModel(namePlayer1);
                PlayerModel player2 = new PlayerModel(namePlayer2);
                PlayerModel player3 = new PlayerModel(namePlayer3);
                GameModel game = new GameModel();
                game.Players.Add(player1);
                game.Players.Add(player2);
                game.Players.Add(player3);

                RoundFormsThreePlayers roundForm = new RoundFormsThreePlayers(game);
                roundForm.Show();
            }
            else if (rbtnFourPlayers.Checked == true)
            {
                string namePlayer1 = txtPlayer1.Text;
                string namePlayer2 = txtPlayer2.Text;
                string namePlayer3 = txtPlayer3.Text;
                string namePlayer4 = txtPlayer4.Text;
                PlayerModel player1 = new PlayerModel(namePlayer1);
                PlayerModel player2 = new PlayerModel(namePlayer2);
                PlayerModel player3 = new PlayerModel(namePlayer3);
                PlayerModel player4 = new PlayerModel(namePlayer4);
                GameModel game = new GameModel();
                game.Players.Add(player1);
                game.Players.Add(player2);
                game.Players.Add(player3);
                game.Players.Add(player4);

                RoundFormsFourPlayers roundForm = new RoundFormsFourPlayers(game);
                roundForm.Show();
            }
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
