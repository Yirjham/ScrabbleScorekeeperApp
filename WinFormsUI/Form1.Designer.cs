
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
            this.rbtmThreePlayers = new System.Windows.Forms.RadioButton();
            this.rbtnFourPlayers = new System.Windows.Forms.RadioButton();
            this.groupBoxInitialForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(455, 99);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(390, 29);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Welcome to Scrabble Scorekeeper";
            // 
            // rbtnTwoPlayers
            // 
            this.rbtnTwoPlayers.AutoSize = true;
            this.rbtnTwoPlayers.Location = new System.Drawing.Point(32, 55);
            this.rbtnTwoPlayers.Name = "rbtnTwoPlayers";
            this.rbtnTwoPlayers.Size = new System.Drawing.Size(165, 33);
            this.rbtnTwoPlayers.TabIndex = 2;
            this.rbtnTwoPlayers.TabStop = true;
            this.rbtnTwoPlayers.Text = "Two Players";
            this.rbtnTwoPlayers.UseVisualStyleBackColor = true;
            // 
            // groupBoxInitialForm
            // 
            this.groupBoxInitialForm.Controls.Add(this.rbtnFourPlayers);
            this.groupBoxInitialForm.Controls.Add(this.rbtnTwoPlayers);
            this.groupBoxInitialForm.Controls.Add(this.rbtmThreePlayers);
            this.groupBoxInitialForm.Location = new System.Drawing.Point(209, 222);
            this.groupBoxInitialForm.Name = "groupBoxInitialForm";
            this.groupBoxInitialForm.Size = new System.Drawing.Size(893, 125);
            this.groupBoxInitialForm.TabIndex = 3;
            this.groupBoxInitialForm.TabStop = false;
            this.groupBoxInitialForm.Text = "Select the Amount of Players:";
            // 
            // rbtmThreePlayers
            // 
            this.rbtmThreePlayers.AutoSize = true;
            this.rbtmThreePlayers.Location = new System.Drawing.Point(345, 55);
            this.rbtmThreePlayers.Name = "rbtmThreePlayers";
            this.rbtmThreePlayers.Size = new System.Drawing.Size(182, 33);
            this.rbtmThreePlayers.TabIndex = 4;
            this.rbtmThreePlayers.TabStop = true;
            this.rbtmThreePlayers.Text = "Three Players";
            this.rbtmThreePlayers.UseVisualStyleBackColor = true;
            // 
            // rbtnFourPlayers
            // 
            this.rbtnFourPlayers.AutoSize = true;
            this.rbtnFourPlayers.Location = new System.Drawing.Point(686, 55);
            this.rbtnFourPlayers.Name = "rbtnFourPlayers";
            this.rbtnFourPlayers.Size = new System.Drawing.Size(167, 33);
            this.rbtnFourPlayers.TabIndex = 5;
            this.rbtnFourPlayers.TabStop = true;
            this.rbtnFourPlayers.Text = "Four Players";
            this.rbtnFourPlayers.UseVisualStyleBackColor = true;
            // 
            // frmWelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 695);
            this.Controls.Add(this.groupBoxInitialForm);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
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
        private System.Windows.Forms.RadioButton rbtmThreePlayers;
    }
}

