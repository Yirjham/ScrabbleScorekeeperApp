using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Scoreboard : Form
    {
        private Crud _crud;
        public Scoreboard()
        {
            _crud = new Crud(DataAccessHelper.GetConnectionString());
            InitializeComponent();
        }
        private void Scoreboard_Load(object sender, EventArgs e)
        {
            DisplayPlayerScoarboard();
        }
        private void DisplayPlayerScoarboard()
        {
            scoreBoardGrid.Columns.Clear();
            var players = _crud.LoadAllPlayers().OrderByDescending(s => s.HighestScore).ToList();


            scoreBoardGrid.DataSource = players;
            scoreBoardGrid.Columns.RemoveAt(0);
            scoreBoardGrid.AutoResizeColumns();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteButton_Click(object sender, EventArgs e)
        {
            PlayerMapperModel playerMapper = null;

            if (scoreBoardGrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("You can only delete one player at the time. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (scoreBoardGrid.SelectedRows.Count == 1)
            {
                DialogResult button = MessageBox.Show("Are you sure you want to delete this player?", "Scrabble Scorekeeper",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (button == DialogResult.Yes)
                {
                    if (scoreBoardGrid.CurrentRow.Selected == true)
                    {
                        object rowObject = scoreBoardGrid.CurrentRow.DataBoundItem;
                        if (rowObject is PlayerMapperModel)
                        {
                            playerMapper = (PlayerMapperModel)rowObject;
                        }
                    }

                        _crud.DeletePlayer(playerMapper.Name);
                    this.Close();
                }

            }

          

            

        }
    }
}
