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
    public partial class RoundFormsTwoPlayers : Form
    {
        GameModel game;        
        public RoundFormsTwoPlayers(GameModel currentGame)
        {
            game = currentGame;
            InitializeComponent();
            lblPlayer1Name.Text = game.Players[0].PlayerName;
            lblPlayer2Name.Text = game.Players[1].PlayerName;
            game.TotalRounds = 0;
            lblCurrentRoundNumber.Text = game.TotalRounds.ToString();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isEmptyScoreP1 = DataValidation.isEmpty(txtScorePlayer1.Text);
            bool isEmptyScoreP2 = DataValidation.isEmpty(txtScorePlayer2.Text);
            bool isValidEntryScoreP1 = DataValidation.isValidNumericData(txtScorePlayer1.Text);
            bool isValidEntryScoreP2 = DataValidation.isValidNumericData(txtScorePlayer2.Text);
            bool isValidRangeScoreP1 = DataValidation.isValidRange(txtScorePlayer1.Text);
            bool isValidRangeScoreP2 = DataValidation.isValidRange(txtScorePlayer2.Text);

            if (isEmptyScoreP1 == false && isEmptyScoreP2 == false)
            {
                
                if (isValidEntryScoreP1 == true && isValidEntryScoreP2 == true)
                {
                    if (isValidRangeScoreP1 == true && isValidRangeScoreP2 == true)
                    {
                        game.Players[0].RoundScore = int.Parse(txtScorePlayer1.Text);
                        game.Players[1].RoundScore = int.Parse(txtScorePlayer2.Text);

                        game.Players[0].UpdateRoundSubtotal();
                        game.Players[1].UpdateRoundSubtotal();

                        txtSubtotalPlayer1.Text = game.Players[0].ScoreSubtotal.ToString();
                        txtSubtotalPlayer2.Text = game.Players[1].ScoreSubtotal.ToString();

                        game.TotalRounds++;
                        lblCurrentRoundNumber.Text = game.TotalRounds.ToString();

                        txtScorePlayer1.Clear();
                        txtScorePlayer2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Invalid range. Please try whole numbers between 0 and 130", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid entry. Please try whole numbers","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("Empty entry. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtScorePlayer1.Focus();
        }

        private void btnFinishGame_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Are you sure you want to finish the game?", "Scrabble Scorekeeper", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (button == DialogResult.Yes)
            {
                if (Calculations.IsThereAWinner(game.Players[0], game.Players[1]))
                {
                    game.GameWinner = Calculations.DeterminesWinner(game.Players[0], game.Players[1]);

                    MessageBox.Show($"After { game.TotalRounds } rounds the winner is { game.GameWinner.PlayerName } with " +
                        $"{ game.GameWinner.ScoreSubtotal } points. Congratulations!!!", "WINNER!!!", MessageBoxButtons.OK); 
                }
                else
                {
                    MessageBox.Show($"After { game.TotalRounds } rounds there is no winner as { game.Players[0].PlayerName } and { game.Players[1].PlayerName } both scored { game.GameWinner.ScoreSubtotal } points.");
                }
            }
        }
    }
}
