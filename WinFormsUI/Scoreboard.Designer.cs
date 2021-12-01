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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scoreBoardGrid = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesWon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighestScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoardGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreBoardGrid
            // 
            this.scoreBoardGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scoreBoardGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.scoreBoardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreBoardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.GamesWon,
            this.GamesPlayed,
            this.HighestScore});
            this.scoreBoardGrid.Location = new System.Drawing.Point(27, 28);
            this.scoreBoardGrid.Name = "scoreBoardGrid";
            this.scoreBoardGrid.ReadOnly = true;
            this.scoreBoardGrid.RowHeadersWidth = 62;
            this.scoreBoardGrid.RowTemplate.Height = 28;
            this.scoreBoardGrid.Size = new System.Drawing.Size(621, 326);
            this.scoreBoardGrid.TabIndex = 0;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Names.HeaderText = "Names";
            this.Names.MinimumWidth = 8;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 95;
            // 
            // GamesWon
            // 
            this.GamesWon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GamesWon.HeaderText = "Games Won";
            this.GamesWon.MinimumWidth = 8;
            this.GamesWon.Name = "GamesWon";
            this.GamesWon.ReadOnly = true;
            this.GamesWon.Width = 134;
            // 
            // GamesPlayed
            // 
            this.GamesPlayed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GamesPlayed.HeaderText = "Games Played";
            this.GamesPlayed.MinimumWidth = 8;
            this.GamesPlayed.Name = "GamesPlayed";
            this.GamesPlayed.ReadOnly = true;
            this.GamesPlayed.Width = 148;
            // 
            // HighestScore
            // 
            this.HighestScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.HighestScore.HeaderText = "Highest Score";
            this.HighestScore.MinimumWidth = 8;
            this.HighestScore.Name = "HighestScore";
            this.HighestScore.ReadOnly = true;
            this.HighestScore.Width = 146;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(542, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteButton
            // 
            this.btnDeleteButton.Location = new System.Drawing.Point(423, 380);
            this.btnDeleteButton.Name = "btnDeleteButton";
            this.btnDeleteButton.Size = new System.Drawing.Size(99, 35);
            this.btnDeleteButton.TabIndex = 3;
            this.btnDeleteButton.Text = "Delete";
            this.btnDeleteButton.UseVisualStyleBackColor = true;
            this.btnDeleteButton.Click += new System.EventHandler(this.btnDeleteButton_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 431);
            this.Controls.Add(this.btnDeleteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.scoreBoardGrid);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteButton;
    }
}