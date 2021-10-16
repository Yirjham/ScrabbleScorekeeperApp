using ScorekeeperLibrary;
using ScorekeeperLibrary.DataValidation;
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

namespace WinFormsUI.RoundForms
{
    public partial class RoundFormsTwoPlayers : Form, IForm
    {
        GameModel game;
        PlayerModel player1;
        PlayerModel player2;

        public RoundFormsTwoPlayers(GameModel currentGame)
        {
            game = currentGame;
            player1 = game.Players[0];
            player2 = game.Players[1];

            InitializeComponent();

            lblPlayer1Name.Text = player1.PlayerName;
            lblPlayer2Name.Text = player2.PlayerName;

            game.TotalRounds = 0;
            lblCurrentRoundNumber.Text = game.TotalRounds.ToString();
        }
        // The event below has conditional statements for validating the users' data entries. Updates the subtotal scores if data is valid
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (DataValidation.IsUserEntryEmpty(txtScorePlayer1.Text, txtScorePlayer2.Text) == true)
            {
                MessageBox.Show("Empty entry. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataValidation.isValidNumber(txtScorePlayer1.Text, txtScorePlayer2.Text) == false)
            {
                MessageBox.Show("Invalid entry. Please try whole numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataValidation.isValidRange(txtScorePlayer1.Text, txtScorePlayer2.Text) == false)
            {
                MessageBox.Show("Invalid range. Please try whole numbers between 0 and 130", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Calculations.UpdateScoresAllPlayers(game, this);
            }
        }
        // The event below processes what happens if the user wants to finish the game
        private void btnFinishGame_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Are you sure you want to finish the game?", "Scrabble Scorekeeper", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (button == DialogResult.Yes)
            {
                if (Calculations.IsThereAWinner(player1, player2) == true)
                {
                    game.GameWinner = Calculations.DeterminesWinner(player1, player2);
                    game.GameWinner.UpdateFinalScore();

                    MessageBox.Show(ScorekeeperLibrary.Models.UIMessages.GameWinnerMessage(game, player1, player2), "WINNER!!!", MessageBoxButtons.OK);
                }
                // itsATieScore its the final score of either player1 or player2
                else
                {
                    int itsATieScore = player1.ScoreSubtotal;
                    MessageBox.Show($"After { game.TotalRounds } rounds there is no winner as { player1.PlayerName } and { player2.PlayerName } both scored { itsATieScore } points.");
                }
            }
        }
        // Code for updating the players' subtotal scores after date being validated. Note the int.Parse
        private static void UpdateScoresAllPlayers(GameModel game, RoundFormsTwoPlayers form)
        {
            PlayerModel player1 = game.Players[0];
            PlayerModel player2 = game.Players[1];

            player1.RoundScore = int.Parse(form.txtScorePlayer1.Text);
            player2.RoundScore = int.Parse(form.txtScorePlayer2.Text);

            player1.UpdateRoundSubtotal();
            player2.UpdateRoundSubtotal();

            form.txtSubtotalPlayer1.Text = player1.ScoreSubtotal.ToString();
            form.txtSubtotalPlayer2.Text = player2.ScoreSubtotal.ToString();

            game.TotalRounds++;
            form.lblCurrentRoundNumber.Text = game.TotalRounds.ToString();

            form.txtScorePlayer1.Clear();
            form.txtScorePlayer2.Clear();

            form.txtScorePlayer1.Focus();
        }
        private void UpdateDisplayedScores()
        {

        }
    }
}
