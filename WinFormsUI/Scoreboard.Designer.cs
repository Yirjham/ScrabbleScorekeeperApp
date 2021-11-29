namespace WinFormsUI
{
    partial class Scoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scoreBoardGrid = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesWon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighestScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoardGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreBoardGrid
            // 
            this.scoreBoardGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scoreBoardGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.scoreBoardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreBoardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.GamesWon,
            this.GamesPlayed,
            this.HighestScore});
            this.scoreBoardGrid.Location = new System.Drawing.Point(18, 18);
            this.scoreBoardGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scoreBoardGrid.Name = "scoreBoardGrid";
            this.scoreBoardGrid.ReadOnly = true;
            this.scoreBoardGrid.RowHeadersWidth = 62;
            this.scoreBoardGrid.RowTemplate.Height = 28;
            this.scoreBoardGrid.Size = new System.Drawing.Size(414, 212);
            this.scoreBoardGrid.TabIndex = 0;
            this.scoreBoardGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scoreBoardGrid_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(361, 247);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Names.HeaderText = "Names";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 65;
            // 
            // GamesWon
            // 
            this.GamesWon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GamesWon.HeaderText = "Games Won";
            this.GamesWon.MinimumWidth = 8;
            this.GamesWon.Name = "GamesWon";
            this.GamesWon.ReadOnly = true;
            this.GamesWon.Width = 91;
            // 
            // GamesPlayed
            // 
            this.GamesPlayed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GamesPlayed.HeaderText = "Games Played";
            this.GamesPlayed.MinimumWidth = 8;
            this.GamesPlayed.Name = "GamesPlayed";
            this.GamesPlayed.ReadOnly = true;
            // 
            // HighestScore
            // 
            this.HighestScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.HighestScore.HeaderText = "Highest Score";
            this.HighestScore.MinimumWidth = 8;
            this.HighestScore.Name = "HighestScore";
            this.HighestScore.ReadOnly = true;
            this.HighestScore.Width = 99;
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.scoreBoardGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoardGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scoreBoardGrid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn GamesWon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GamesPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn HighestScore;
    }
}