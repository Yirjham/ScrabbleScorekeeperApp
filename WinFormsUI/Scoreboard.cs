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
        private readonly Crud _crud;
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
            try
            {
                scoreBoardGrid.Columns.Clear();
                var players = _crud.LoadAllPlayers().OrderByDescending(s => s.HighestScore).ToList();

                scoreBoardGrid.DataSource = players;
                scoreBoardGrid.Columns.RemoveAt(0);
                scoreBoardGrid.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong when accessing the database: { ex.Message }\n\nStack Trace:{ex.StackTrace}",
                    "Database access error (Exception)", MessageBoxButtons.OK, MessageBoxIcon.Error );
                this.Close();
            }
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
                return;
            }

            if (scoreBoardGrid.CurrentRow != null)
            {
                DialogResult button = MessageBox.Show("Are you sure you want to delete this player?", "Scrabble Scorekeeper",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (button == DialogResult.Yes && scoreBoardGrid.CurrentRow.Selected == true)
                {
                    try
                    {
                        object rowObject = scoreBoardGrid.CurrentRow.DataBoundItem;

                        playerMapper = (PlayerMapperModel)rowObject;

                        _crud.DeletePlayer(playerMapper.Name);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Something went wrong when accessing the database: { ex.Message }\n\nStack Trace:{ex.StackTrace}",
                    "Database access error (Exception)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Close();
                    }
                }
            }

            else 
            {
                MessageBox.Show("Error, there are no players left to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
