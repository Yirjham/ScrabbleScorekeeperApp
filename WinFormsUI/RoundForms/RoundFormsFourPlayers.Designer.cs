
namespace WinFormsUI.RoundForms
{
    partial class RoundFormsFourPlayers
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
            this.btnFinishGame = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtSubtotalPlayer3 = new System.Windows.Forms.TextBox();
            this.txtSubtotalPlayer2 = new System.Windows.Forms.TextBox();
            this.txtSubtotalPlayer1 = new System.Windows.Forms.TextBox();
            this.txtScorePlayer3 = new System.Windows.Forms.TextBox();
            this.txtScorePlayer2 = new System.Windows.Forms.TextBox();
            this.txtScorePlayer1 = new System.Windows.Forms.TextBox();
            this.lblCurrentRoundNumber = new System.Windows.Forms.Label();
            this.lblCurrentRound = new System.Windows.Forms.Label();
            this.lblPlayer3Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer4Name = new System.Windows.Forms.Label();
            this.txtScorePlayer4 = new System.Windows.Forms.TextBox();
            this.txtSubtotalPlayer4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFinishGame
            // 
            this.btnFinishGame.Location = new System.Drawing.Point(283, 370);
            this.btnFinishGame.Name = "btnFinishGame";
            this.btnFinishGame.Size = new System.Drawing.Size(122, 36);
            this.btnFinishGame.TabIndex = 31;
            this.btnFinishGame.Text = "Finish";
            this.btnFinishGame.UseVisualStyleBackColor = true;
            this.btnFinishGame.Click += new System.EventHandler(this.btnFinishGame_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(130, 368);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 38);
            this.btnEnter.TabIndex = 29;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(282, 101);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(101, 29);
            this.lblSubtotal.TabIndex = 36;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(125, 101);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(77, 29);
            this.lblScore.TabIndex = 35;
            this.lblScore.Text = "Score";
            // 
            // txtSubtotalPlayer3
            // 
            this.txtSubtotalPlayer3.Location = new System.Drawing.Point(283, 246);
            this.txtSubtotalPlayer3.Name = "txtSubtotalPlayer3";
            this.txtSubtotalPlayer3.ReadOnly = true;
            this.txtSubtotalPlayer3.Size = new System.Drawing.Size(122, 35);
            this.txtSubtotalPlayer3.TabIndex = 33;
            this.txtSubtotalPlayer3.TabStop = false;
            // 
            // txtSubtotalPlayer2
            // 
            this.txtSubtotalPlayer2.Location = new System.Drawing.Point(283, 187);
            this.txtSubtotalPlayer2.Name = "txtSubtotalPlayer2";
            this.txtSubtotalPlayer2.ReadOnly = true;
            this.txtSubtotalPlayer2.Size = new System.Drawing.Size(122, 35);
            this.txtSubtotalPlayer2.TabIndex = 34;
            this.txtSubtotalPlayer2.TabStop = false;
            // 
            // txtSubtotalPlayer1
            // 
            this.txtSubtotalPlayer1.Location = new System.Drawing.Point(283, 133);
            this.txtSubtotalPlayer1.Name = "txtSubtotalPlayer1";
            this.txtSubtotalPlayer1.ReadOnly = true;
            this.txtSubtotalPlayer1.Size = new System.Drawing.Size(122, 35);
            this.txtSubtotalPlayer1.TabIndex = 32;
            this.txtSubtotalPlayer1.TabStop = false;
            // 
            // txtScorePlayer3
            // 
            this.txtScorePlayer3.Location = new System.Drawing.Point(130, 246);
            this.txtScorePlayer3.Name = "txtScorePlayer3";
            this.txtScorePlayer3.Size = new System.Drawing.Size(100, 35);
            this.txtScorePlayer3.TabIndex = 26;
            // 
            // txtScorePlayer2
            // 
            this.txtScorePlayer2.Location = new System.Drawing.Point(130, 187);
            this.txtScorePlayer2.Name = "txtScorePlayer2";
            this.txtScorePlayer2.Size = new System.Drawing.Size(100, 35);
            this.txtScorePlayer2.TabIndex = 27;
            // 
            // txtScorePlayer1
            // 
            this.txtScorePlayer1.Location = new System.Drawing.Point(130, 133);
            this.txtScorePlayer1.Name = "txtScorePlayer1";
            this.txtScorePlayer1.Size = new System.Drawing.Size(100, 35);
            this.txtScorePlayer1.TabIndex = 23;
            // 
            // lblCurrentRoundNumber
            // 
            this.lblCurrentRoundNumber.AutoSize = true;
            this.lblCurrentRoundNumber.Location = new System.Drawing.Point(112, 32);
            this.lblCurrentRoundNumber.Name = "lblCurrentRoundNumber";
            this.lblCurrentRoundNumber.Size = new System.Drawing.Size(100, 29);
            this.lblCurrentRoundNumber.TabIndex = 30;
            this.lblCurrentRoundNumber.Text = "Number";
            // 
            // lblCurrentRound
            // 
            this.lblCurrentRound.AutoSize = true;
            this.lblCurrentRound.Location = new System.Drawing.Point(27, 32);
            this.lblCurrentRound.Name = "lblCurrentRound";
            this.lblCurrentRound.Size = new System.Drawing.Size(90, 29);
            this.lblCurrentRound.TabIndex = 28;
            this.lblCurrentRound.Text = "Round:";
            // 
            // lblPlayer3Name
            // 
            this.lblPlayer3Name.AutoSize = true;
            this.lblPlayer3Name.Location = new System.Drawing.Point(27, 252);
            this.lblPlayer3Name.Name = "lblPlayer3Name";
            this.lblPlayer3Name.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer3Name.TabIndex = 24;
            this.lblPlayer3Name.Text = "Player 3:";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(27, 193);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer2Name.TabIndex = 25;
            this.lblPlayer2Name.Text = "Player 2:";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(27, 136);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer1Name.TabIndex = 22;
            this.lblPlayer1Name.Text = "Player 1:";
            // 
            // lblPlayer4Name
            // 
            this.lblPlayer4Name.AutoSize = true;
            this.lblPlayer4Name.Location = new System.Drawing.Point(27, 309);
            this.lblPlayer4Name.Name = "lblPlayer4Name";
            this.lblPlayer4Name.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer4Name.TabIndex = 24;
            this.lblPlayer4Name.Text = "Player 4:";
            // 
            // txtScorePlayer4
            // 
            this.txtScorePlayer4.Location = new System.Drawing.Point(130, 303);
            this.txtScorePlayer4.Name = "txtScorePlayer4";
            this.txtScorePlayer4.Size = new System.Drawing.Size(100, 35);
            this.txtScorePlayer4.TabIndex = 26;
            // 
            // txtSubtotalPlayer4
            // 
            this.txtSubtotalPlayer4.Location = new System.Drawing.Point(283, 303);
            this.txtSubtotalPlayer4.Name = "txtSubtotalPlayer4";
            this.txtSubtotalPlayer4.ReadOnly = true;
            this.txtSubtotalPlayer4.Size = new System.Drawing.Size(122, 35);
            this.txtSubtotalPlayer4.TabIndex = 33;
            this.txtSubtotalPlayer4.TabStop = false;
            // 
            // RoundFormsFourPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 422);
            this.Controls.Add(this.btnFinishGame);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtSubtotalPlayer4);
            this.Controls.Add(this.txtSubtotalPlayer3);
            this.Controls.Add(this.txtSubtotalPlayer2);
            this.Controls.Add(this.txtSubtotalPlayer1);
            this.Controls.Add(this.txtScorePlayer4);
            this.Controls.Add(this.txtScorePlayer3);
            this.Controls.Add(this.txtScorePlayer2);
            this.Controls.Add(this.txtScorePlayer1);
            this.Controls.Add(this.lblCurrentRoundNumber);
            this.Controls.Add(this.lblCurrentRound);
            this.Controls.Add(this.lblPlayer4Name);
            this.Controls.Add(this.lblPlayer3Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "RoundFormsFourPlayers";
            this.Text = "RoundFormsFourPlayers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinishGame;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtSubtotalPlayer3;
        private System.Windows.Forms.TextBox txtSubtotalPlayer2;
        private System.Windows.Forms.TextBox txtSubtotalPlayer1;
        private System.Windows.Forms.TextBox txtScorePlayer3;
        private System.Windows.Forms.TextBox txtScorePlayer2;
        private System.Windows.Forms.TextBox txtScorePlayer1;
        private System.Windows.Forms.Label lblCurrentRoundNumber;
        private System.Windows.Forms.Label lblCurrentRound;
        private System.Windows.Forms.Label lblPlayer3Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer4Name;
        private System.Windows.Forms.TextBox txtScorePlayer4;
        private System.Windows.Forms.TextBox txtSubtotalPlayer4;
    }
}