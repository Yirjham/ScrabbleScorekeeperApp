
namespace WinFormsUI
{
    partial class frmWelcomeWindow
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
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.rbtnTwoPlayers = new System.Windows.Forms.RadioButton();
            this.groupBoxInitialForm = new System.Windows.Forms.GroupBox();
            this.rbtnFourPlayers = new System.Windows.Forms.RadioButton();
            this.rbtnThreePlayers = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer3 = new System.Windows.Forms.TextBox();
            this.txtPlayer4 = new System.Windows.Forms.TextBox();
            this.btnViewScoreboard = new System.Windows.Forms.Button();
            this.lblEnterNames = new System.Windows.Forms.Label();
            this.groupBoxInitialForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(13, 9);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(195, 29);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "SCOREKEEPER";
            // 
            // rbtnTwoPlayers
            // 
            this.rbtnTwoPlayers.AutoSize = true;
            this.rbtnTwoPlayers.Location = new System.Drawing.Point(8, 41);
            this.rbtnTwoPlayers.Name = "rbtnTwoPlayers";
            this.rbtnTwoPlayers.Size = new System.Drawing.Size(159, 33);
            this.rbtnTwoPlayers.TabIndex = 2;
            this.rbtnTwoPlayers.TabStop = true;
            this.rbtnTwoPlayers.Text = "2 PLAYERS";
            this.rbtnTwoPlayers.UseVisualStyleBackColor = true;
            this.rbtnTwoPlayers.CheckedChanged += new System.EventHandler(this.rbtnTwoPlayers_CheckedChanged);
            // 
            // groupBoxInitialForm
            // 
            this.groupBoxInitialForm.Controls.Add(this.rbtnFourPlayers);
            this.groupBoxInitialForm.Controls.Add(this.rbtnTwoPlayers);
            this.groupBoxInitialForm.Controls.Add(this.rbtnThreePlayers);
            this.groupBoxInitialForm.Location = new System.Drawing.Point(18, 58);
            this.groupBoxInitialForm.Name = "groupBoxInitialForm";
            this.groupBoxInitialForm.Size = new System.Drawing.Size(246, 161);
            this.groupBoxInitialForm.TabIndex = 3;
            this.groupBoxInitialForm.TabStop = false;
            this.groupBoxInitialForm.Text = "SELECT TYPE:";
            // 
            // rbtnFourPlayers
            // 
            this.rbtnFourPlayers.AutoSize = true;
            this.rbtnFourPlayers.Location = new System.Drawing.Point(8, 119);
            this.rbtnFourPlayers.Name = "rbtnFourPlayers";
            this.rbtnFourPlayers.Size = new System.Drawing.Size(159, 33);
            this.rbtnFourPlayers.TabIndex = 5;
            this.rbtnFourPlayers.TabStop = true;
            this.rbtnFourPlayers.Text = "4 PLAYERS";
            this.rbtnFourPlayers.UseVisualStyleBackColor = true;
            this.rbtnFourPlayers.CheckedChanged += new System.EventHandler(this.rbtnFourPlayers_CheckedChanged);
            // 
            // rbtnThreePlayers
            // 
            this.rbtnThreePlayers.AutoSize = true;
            this.rbtnThreePlayers.Location = new System.Drawing.Point(8, 80);
            this.rbtnThreePlayers.Name = "rbtnThreePlayers";
            this.rbtnThreePlayers.Size = new System.Drawing.Size(159, 33);
            this.rbtnThreePlayers.TabIndex = 4;
            this.rbtnThreePlayers.TabStop = true;
            this.rbtnThreePlayers.Text = "3 PLAYERS";
            this.rbtnThreePlayers.UseVisualStyleBackColor = true;
            this.rbtnThreePlayers.CheckedChanged += new System.EventHandler(this.rbtnThreePlayers_CheckedChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(301, 267);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(249, 35);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(296, 99);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(125, 29);
            this.lblPlayer1.TabIndex = 5;
            this.lblPlayer1.Text = "PLAYER 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(296, 141);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(125, 29);
            this.lblPlayer2.TabIndex = 6;
            this.lblPlayer2.Text = "PLAYER 2";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Location = new System.Drawing.Point(296, 183);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(125, 29);
            this.lblPlayer3.TabIndex = 7;
            this.lblPlayer3.Text = "PLAYER 3";
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Location = new System.Drawing.Point(296, 226);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(125, 29);
            this.lblPlayer4.TabIndex = 8;
            this.lblPlayer4.Text = "PLAYER 4";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(427, 99);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(122, 35);
            this.txtPlayer1.TabIndex = 9;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(427, 141);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(123, 35);
            this.txtPlayer2.TabIndex = 10;
            // 
            // txtPlayer3
            // 
            this.txtPlayer3.Location = new System.Drawing.Point(427, 183);
            this.txtPlayer3.Name = "txtPlayer3";
            this.txtPlayer3.Size = new System.Drawing.Size(123, 35);
            this.txtPlayer3.TabIndex = 11;
            // 
            // txtPlayer4
            // 
            this.txtPlayer4.Location = new System.Drawing.Point(427, 226);
            this.txtPlayer4.Name = "txtPlayer4";
            this.txtPlayer4.Size = new System.Drawing.Size(123, 35);
            this.txtPlayer4.TabIndex = 12;
            // 
            // btnViewScoreboard
            // 
            this.btnViewScoreboard.Location = new System.Drawing.Point(18, 267);
            this.btnViewScoreboard.Name = "btnViewScoreboard";
            this.btnViewScoreboard.Size = new System.Drawing.Size(246, 35);
            this.btnViewScoreboard.TabIndex = 13;
            this.btnViewScoreboard.Text = "View Scoreboard";
            this.btnViewScoreboard.UseVisualStyleBackColor = true;
            this.btnViewScoreboard.Click += new System.EventHandler(this.btnViewScoreboard_Click);
            // 
            // lblEnterNames
            // 
            this.lblEnterNames.AutoSize = true;
            this.lblEnterNames.Location = new System.Drawing.Point(296, 58);
            this.lblEnterNames.Name = "lblEnterNames";
            this.lblEnterNames.Size = new System.Drawing.Size(193, 29);
            this.lblEnterNames.TabIndex = 14;
            this.lblEnterNames.Text = "ENTER NAMES:";
            // 
            // frmWelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 323);
            this.Controls.Add(this.lblEnterNames);
            this.Controls.Add(this.btnViewScoreboard);
            this.Controls.Add(this.txtPlayer4);
            this.Controls.Add(this.txtPlayer3);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBoxInitialForm);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmWelcomeWindow";
            this.Text = "Scrabble Scorekeeper by Yirjham Grossl";
            this.groupBoxInitialForm.ResumeLayout(false);
            this.groupBoxInitialForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.RadioButton rbtnTwoPlayers;
        private System.Windows.Forms.GroupBox groupBoxInitialForm;
        private System.Windows.Forms.RadioButton rbtnFourPlayers;
        private System.Windows.Forms.RadioButton rbtnThreePlayers;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer3;
        private System.Windows.Forms.TextBox txtPlayer4;
        private System.Windows.Forms.Button btnViewScoreboard;
        private System.Windows.Forms.Label lblEnterNames;
    }
}

