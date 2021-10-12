
namespace WinFormsUI
{
    partial class PlayersNamesWindowTwoPlayers
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
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblMainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(119, 245);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(231, 150);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(222, 35);
            this.txtPlayer1.TabIndex = 2;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(231, 242);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(222, 35);
            this.txtPlayer2.TabIndex = 3;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(119, 153);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "Player 1:";
            // 
            // lblMainLabel
            // 
            this.lblMainLabel.AutoSize = true;
            this.lblMainLabel.Location = new System.Drawing.Point(119, 69);
            this.lblMainLabel.Name = "lblMainLabel";
            this.lblMainLabel.Size = new System.Drawing.Size(361, 29);
            this.lblMainLabel.TabIndex = 5;
            this.lblMainLabel.Text = "ENTER THE PLAYERS\' NAMES";
            // 
            // PlayersNamesWindowTwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 570);
            this.Controls.Add(this.lblMainLabel);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "PlayersNamesWindowTwoPlayers";
            this.Text = "Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblMainLabel;
    }
}