
namespace WinFormsUI
{
    partial class PlayerNamesWindowFourPlayers
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
            this.lblMainLabel = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.txtPlayer3Name = new System.Windows.Forms.TextBox();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.txtPlayer4Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMainLabel
            // 
            this.lblMainLabel.AutoSize = true;
            this.lblMainLabel.Location = new System.Drawing.Point(143, 65);
            this.lblMainLabel.Name = "lblMainLabel";
            this.lblMainLabel.Size = new System.Drawing.Size(361, 29);
            this.lblMainLabel.TabIndex = 10;
            this.lblMainLabel.Text = "ENTER THE PLAYERS\' NAMES";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(143, 149);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer1.TabIndex = 9;
            this.lblPlayer1.Text = "Player 1:";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(255, 238);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(222, 35);
            this.txtPlayer2Name.TabIndex = 8;
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(255, 146);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(222, 35);
            this.txtPlayer1Name.TabIndex = 7;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(143, 241);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer2.TabIndex = 6;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Location = new System.Drawing.Point(143, 334);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer3.TabIndex = 6;
            this.lblPlayer3.Text = "Player 3:";
            // 
            // txtPlayer3Name
            // 
            this.txtPlayer3Name.Location = new System.Drawing.Point(255, 331);
            this.txtPlayer3Name.Name = "txtPlayer3Name";
            this.txtPlayer3Name.Size = new System.Drawing.Size(222, 35);
            this.txtPlayer3Name.TabIndex = 8;
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Location = new System.Drawing.Point(143, 424);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer4.TabIndex = 6;
            this.lblPlayer4.Text = "Player 4:";
            // 
            // txtPlayer4Name
            // 
            this.txtPlayer4Name.Location = new System.Drawing.Point(255, 421);
            this.txtPlayer4Name.Name = "txtPlayer4Name";
            this.txtPlayer4Name.Size = new System.Drawing.Size(222, 35);
            this.txtPlayer4Name.TabIndex = 8;
            // 
            // PlayerNamesWindowThreePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 570);
            this.Controls.Add(this.lblMainLabel);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txtPlayer4Name);
            this.Controls.Add(this.txtPlayer3Name);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "PlayerNamesWindowThreePlayers";
            this.Text = "Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainLabel;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.TextBox txtPlayer3Name;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.TextBox txtPlayer4Name;
    }
}