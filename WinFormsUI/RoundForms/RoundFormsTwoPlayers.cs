using DataAccessLibrary;
using DataAccessLibrary.Models;
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
        private GameModel game;
        private PlayerModel _player1;
        private PlayerModel _player2;
        private readonly Crud _crud;
        private List<PlayerMapperModel> _players;
        private List<string> _playersNames;
        private readonly DataAccessHelper _dataAccessHelper;

        public RoundFormsTwoPlayers(GameModel currentGame)
        {
            _crud = new Crud(DataAccessHelper.GetConnectionString());
            _dataAccessHelper = new DataAccessHelper(_crud);
            _players = _crud.LoadAllPlayers();
            _playersNames = _players.Select(p => p.Name).ToList();

            game = currentGame;
            _player1 = game.Players[0];
            _player2 = game.Players[1];

            InitializeComponent();

            lblPlayer1Name.Text = _player1.PlayerName;
            lblPlayer2Name.Text = _player2.PlayerName;

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
                txtScorePlayer1.Focus();
            }
        }
        // The event below processes what happens if the user wants to finish the game
        private void btnFinishGame_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Are you sure you want to finish the game?", "Scrabble Scorekeeper", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (button == DialogResult.Yes)
            {
                PlayerModel loser = null;

                if (Calculations.IsThereAWinner(game.Players[0].ScoreSubtotal, game.Players[1].ScoreSubtotal) == true)
                {
                    game.GameWinner = Calculations.DeterminesWinner(_player1, _player2);
                    game.GameWinner.UpdateFinalScore();

                    loser = Calculations.ReturnsLosers(_player1, _player2)[0]; // new line added, test that it works with the new logic
                    loser.UpdateFinalScore();

                    MessageBox.Show(ScorekeeperLibrary.Models.UIMessages.GameWinnerMessage(game, _player1, _player2), "WINNER!!!", MessageBoxButtons.OK);

                    if (DataAccessHelper.PlayerAlreadyInDB(_playersNames, game.GameWinner) == true)
                    {
                        _dataAccessHelper.UpdateExistingPlayerData(_playersNames, game.GameWinner, game);
                    }
                    else
                    {
                        
                        _dataAccessHelper.AddNewPlayerToDb(game.GameWinner, true);
                        
                    }

                    if ((DataAccessHelper.PlayerAlreadyInDB(_playersNames, loser) == true))
                    {
                        _dataAccessHelper.UpdateExistingPlayerData(_playersNames, loser, game);
                    }
                    else
                    {
                        _dataAccessHelper.AddNewPlayerToDb(loser, false);
                    }
                    
                    
                }
                // No winner, players in a tie
                else
                {
                    int itsATieScore = _player1.ScoreSubtotal;
                    MessageBox.Show($"After { game.TotalRounds } rounds there is no winner as { _player1.PlayerName } and { _player2.PlayerName } both scored { itsATieScore } points.");

                    // No winners
                    _player1.UpdateFinalScore();
                    _player2.UpdateFinalScore();

                    if (DataAccessHelper.PlayerAlreadyInDB(_playersNames, _player1) == true)
                    {
                        PlayerMapperModel player1Mapper = _crud.ReadPlayer(_player1.PlayerName);
                        player1Mapper.GamesPlayed++;
                        Calculations.UpdatePlayerHighestScore(_player1, player1Mapper);
                        _crud.UpdatePlayerData(player1Mapper.Id, player1Mapper);
                    }
                    else
                    {
                        _dataAccessHelper.AddNewPlayerToDb(_player1, false);
                    }

                    if (DataAccessHelper.PlayerAlreadyInDB(_playersNames, _player2) == true)
                    {
                        PlayerMapperModel player2Mapper = _crud.ReadPlayer(_player2.PlayerName);
                        player2Mapper.GamesPlayed++;
                        Calculations.UpdatePlayerHighestScore(_player2, player2Mapper);
                        _crud.UpdatePlayerData(player2Mapper.Id, player2Mapper);
                    }
                    else
                    {
                        _dataAccessHelper.AddNewPlayerToDb(_player2, false);
                    }
                }

                this.Close();
            }
        }
        public void UpdatePlayersRoundScores()
        {
            _player1.RoundScore = int.Parse(txtScorePlayer1.Text);
            _player2.RoundScore = int.Parse(txtScorePlayer2.Text);
        }
        public void UpdateDisplayedSubtotals()
        {
            txtSubtotalPlayer1.Text = _player1.ScoreSubtotal.ToString();
            txtSubtotalPlayer2.Text = _player2.ScoreSubtotal.ToString();
        }

        public void UpdateDisplayedCurrentRound()
        {
            lblCurrentRoundNumber.Text = game.TotalRounds.ToString();
        }

        public void ClearDisplayedScores()
        {
            txtScorePlayer1.Clear();
            txtScorePlayer2.Clear();
        }
    }
}
