
namespace WinFormsUI.RoundForms
{
    partial class RoundFormsTwoPlayers
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
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblCurrentRound = new System.Windows.Forms.Label();
            this.lblCurrentRoundNumber = new System.Windows.Forms.Label();
            this.txtScorePlayer1 = new System.Windows.Forms.TextBox();
            this.txtScorePlayer2 = new System.Windows.Forms.TextBox();
            this.txtSubtotalPlayer1 = new System.Windows.Forms.TextBox();
            this.txtSubtotalPlayer2 = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnFinishGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(12, 117);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer1Name.TabIndex = 0;
            this.lblPlayer1Name.Text = "Player 1:";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(12, 174);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer2Name.TabIndex = 1;
            this.lblPlayer2Name.Text = "Player 2:";
            // 
            // lblCurrentRound
            // 
            this.lblCurrentRound.AutoSize = true;
            this.lblCurrentRound.Location = new System.Drawing.Point(14, 24);
            this.lblCurrentRound.Name = "lblCurrentRound";
            this.lblCurrentRound.Size = new System.Drawing.Size(90, 29);
            this.lblCurrentRound.TabIndex = 2;
            this.lblCurrentRound.Text = "Round:";
            // 
            // lblCurrentRoundNumber
            // 
            this.lblCurrentRoundNumber.AutoSize = true;
            this.lblCurrentRoundNumber.Location = new System.Drawing.Point(99, 24);
            this.lblCurrentRoundNumber.Name = "lblCurrentRoundNumber";
            this.lblCurrentRoundNumber.Size = new System.Drawing.Size(100, 29);
            this.lblCurrentRoundNumber.TabIndex = 3;
            this.lblCurrentRoundNumber.Text = "Number";
            // 
            // txtScorePlayer1
            // 
            this.txtScorePlayer1.Location = new System.Drawing.Point(115, 114);
            this.txtScorePlayer1.Name = "txtScorePlayer1";
            this.txtScorePlayer1.Size = new System.Drawing.Size(100, 35);
            this.txtScorePlayer1.TabIndex = 1;
            // 
            // txtScorePlayer2
            // 
            this.txtScorePlayer2.Location = new System.Drawing.Point(115, 168);
            this.txtScorePlayer2.Name = "txtScorePlayer2";
            this.txtScorePlayer2.Size = new System.Drawing.Size(100, 35);
            this.txtScorePlayer2.TabIndex = 2;
            // 
            // txtSubtotalPlayer1
            // 
            this.txtSubtotalPlayer1.Location = new System.Drawing.Point(268, 114);
            this.txtSubtotalPlayer1.Name = "txtSubtotalPlayer1";
            this.txtSubtotalPlayer1.ReadOnly = true;
            this.txtSubtotalPlayer1.Size = new System.Drawing.Size(100, 35);
            this.txtSubtotalPlayer1.TabIndex = 6;
            this.txtSubtotalPlayer1.TabStop = false;
            // 
            // txtSubtotalPlayer2
            // 
            this.txtSubtotalPlayer2.Location = new System.Drawing.Point(268, 168);
            this.txtSubtotalPlayer2.Name = "txtSubtotalPlayer2";
            this.txtSubtotalPlayer2.ReadOnly = true;
            this.txtSubtotalPlayer2.Size = new System.Drawing.Size(100, 35);
            this.txtSubtotalPlayer2.TabIndex = 7;
            this.txtSubtotalPlayer2.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(110, 82);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(77, 29);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(267, 82);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(101, 29);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(115, 229);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 38);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnFinishGame
            // 
            this.btnFinishGame.Location = new System.Drawing.Point(268, 231);
            this.btnFinishGame.Name = "btnFinishGame";
            this.btnFinishGame.Size = new System.Drawing.Size(100, 36);
            this.btnFinishGame.TabIndex = 4;
            this.btnFinishGame.Text = "Finish";
            this.btnFinishGame.UseVisualStyleBackColor = true;
            this.btnFinishGame.Click += new System.EventHandler(this.btnFinishGame_Click);
            // 
            // RoundFormsTwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 299);
            this.Controls.Add(this.btnFinishGame);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtSubtotalPlayer2);
            this.Controls.Add(this.txtSubtotalPlayer1);
            this.Controls.Add(this.txtScorePlayer2);
            this.Controls.Add(this.txtScorePlayer1);
            this.Controls.Add(this.lblCurrentRoundNumber);
            this.Controls.Add(this.lblCurrentRound);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "RoundFormsTwoPlayers";
            this.Text = "RoundFormsTwoPlayers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblCurrentRound;
        private System.Windows.Forms.Label lblCurrentRoundNumber;
        private System.Windows.Forms.TextBox txtScorePlayer1;
        private System.Windows.Forms.TextBox txtScorePlayer2;
        private System.Windows.Forms.TextBox txtSubtotalPlayer1;
        private System.Windows.Forms.TextBox txtSubtotalPlayer2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnFinishGame;
    }
}