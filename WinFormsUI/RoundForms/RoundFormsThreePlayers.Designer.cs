
namespace WinFormsUI.RoundForms
{
    partial class RoundFormsThreePlayers
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
            this.txtSubtotalPlayer2 = new System.Windows.Forms.TextBox();
            this.txtSubtotalPlayer1 = new System.Windows.Forms.TextBox();
            this.txtScorePlayer2 = new System.Windows.Forms.TextBox();
            this.txtScorePlayer1 = new System.Windows.Forms.TextBox();
            this.lblCurrentRoundNumber = new System.Windows.Forms.Label();
            this.lblCurrentRound = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer3Name = new System.Windows.Forms.Label();
            this.txtScorePlayer3 = new System.Windows.Forms.TextBox();
            this.txtSubtotalPlayer3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFinishGame
            // 
            this.btnFinishGame.Location = new System.Drawing.Point(278, 299);
            this.btnFinishGame.Name = "btnFinishGame";
            this.btnFinishGame.Size = new System.Drawing.Size(122, 36);
            this.btnFinishGame.TabIndex = 17;
            this.btnFinishGame.Text = "Finish";
            this.btnFinishGame.UseVisualStyleBackColor = true;
            this.btnFinishGame.Click += new System.EventHandler(this.btnFinishGame_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(125, 297);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 38);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(277, 86);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(101, 29);
            this.lblSubtotal.TabIndex = 21;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(120, 86);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(77, 29);
            this.lblScore.TabIndex = 20;
            this.lblScore.Text = "Score";
            // 
            // txtSubtotalPlayer2
            // 
            this.txtSubtotalPlayer2.Location = new System.Drawing.Point(278, 172);
            this.txtSubtotalPlayer2.Name = "txtSubtotalPlayer2";
            this.txtSubtotalPlayer2.ReadOnly = true;
            this.txtSubtotalPlayer2.Size = new System.Drawing.Size(122, 35);
            this.txtSubtotalPlayer2.TabIndex = 19;
            this.txtSubtotalPlayer2.TabStop = false;
            // 
            // txtSubtotalPlayer1
            // 
            this.txtSubtotalPlayer1.Location = new System.Drawing.Point(278, 118);
            this.txtSubtotalPlayer1.Name = "txtSubtotalPlayer1";
            this.txtSubtotalPlayer1.ReadOnly = true;
            this.txtSubtotalPlayer1.Size = new System.Drawing.Size(122, 35);
            this.txtSubtotalPlayer1.TabIndex = 18;
            this.txtSubtotalPlayer1.TabStop = false;
            // 
            // txtScorePlayer2
            // 
            this.txtScorePlayer2.Location = new System.Drawing.Point(125, 172);
            this.txtScorePlayer2.Name = "txtScorePlayer2";
            this.txtScorePlayer2.Size = new System.Drawing.Size(100, 35);
            this.txtScorePlayer2.TabIndex = 13;
            // 
            // txtScorePlayer1
            // 
            this.txtScorePlayer1.Location = new System.Drawing.Point(125, 118);
            this.txtScorePlayer1.Name = "txtScorePlayer1";
            this.txtScorePlayer1.Size = new System.Drawing.Size(100, 35);
            this.txtScorePlayer1.TabIndex = 11;
            // 
            // lblCurrentRoundNumber
            // 
            this.lblCurrentRoundNumber.AutoSize = true;
            this.lblCurrentRoundNumber.Location = new System.Drawing.Point(107, 37);
            this.lblCurrentRoundNumber.Name = "lblCurrentRoundNumber";
            this.lblCurrentRoundNumber.Size = new System.Drawing.Size(100, 29);
            this.lblCurrentRoundNumber.TabIndex = 16;
            this.lblCurrentRoundNumber.Text = "Number";
            // 
            // lblCurrentRound
            // 
            this.lblCurrentRound.AutoSize = true;
            this.lblCurrentRound.Location = new System.Drawing.Point(22, 37);
            this.lblCurrentRound.Name = "lblCurrentRound";
            this.lblCurrentRound.Size = new System.Drawing.Size(90, 29);
            this.lblCurrentRound.TabIndex = 14;
            this.lblCurrentRound.Text = "Round:";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(22, 178);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer2Name.TabIndex = 12;
            this.lblPlayer2Name.Text = "Player 2:";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(22, 121);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer1Name.TabIndex = 10;
            this.lblPlayer1Name.Text = "Player 1:";
            // 
            // lblPlayer3Name
            // 
            this.lblPlayer3Name.AutoSize = true;
            this.lblPlayer3Name.Location = new System.Drawing.Point(22, 237);
            this.lblPlayer3Name.Name = "lblPlayer3Name";
            this.lblPlayer3Name.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer3Name.TabIndex = 12;
            this.lblPlayer3Name.Text = "Player 3:";
            // 
            // txtScorePlayer3
            // 
            this.txtScorePlayer3.Location = new System.Drawing.Point(125, 231);
            this.txtScorePlayer3.Name = "txtScorePlayer3";
            this.txtScorePlayer3.Size = new System.Drawing.Size(100, 35);
            this.txtScorePlayer3.TabIndex = 13;
            // 
            // txtSubtotalPlayer3
            // 
            this.txtSubtotalPlayer3.Location = new System.Drawing.Point(278, 231);
            this.txtSubtotalPlayer3.Name = "txtSubtotalPlayer3";
            this.txtSubtotalPlayer3.ReadOnly = true;
            this.txtSubtotalPlayer3.Size = new System.Drawing.Size(122, 35);
            this.txtSubtotalPlayer3.TabIndex = 19;
            this.txtSubtotalPlayer3.TabStop = false;
            // 
            // RoundFormsThreePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 353);
            this.Controls.Add(this.btnFinishGame);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtSubtotalPlayer3);
            this.Controls.Add(this.txtSubtotalPlayer2);
            this.Controls.Add(this.txtSubtotalPlayer1);
            this.Controls.Add(this.txtScorePlayer3);
            this.Controls.Add(this.txtScorePlayer2);
            this.Controls.Add(this.txtScorePlayer1);
            this.Controls.Add(this.lblCurrentRoundNumber);
            this.Controls.Add(this.lblCurrentRound);
            this.Controls.Add(this.lblPlayer3Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "RoundFormsThreePlayers";
            this.Text = "RoundFormsThreePlayers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinishGame;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtSubtotalPlayer2;
        private System.Windows.Forms.TextBox txtSubtotalPlayer1;
        private System.Windows.Forms.TextBox txtScorePlayer2;
        private System.Windows.Forms.TextBox txtScorePlayer1;
        private System.Windows.Forms.Label lblCurrentRoundNumber;
        private System.Windows.Forms.Label lblCurrentRound;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer3Name;
        private System.Windows.Forms.TextBox txtScorePlayer3;
        private System.Windows.Forms.TextBox txtSubtotalPlayer3;
    }
}