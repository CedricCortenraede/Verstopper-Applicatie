namespace Verstopper
{
    partial class GameMenu
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimeLeftLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // gameTimeLeftLabel
            // 
            this.gameTimeLeftLabel.AutoSize = true;
            this.gameTimeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTimeLeftLabel.Location = new System.Drawing.Point(3, 33);
            this.gameTimeLeftLabel.Name = "gameTimeLeftLabel";
            this.gameTimeLeftLabel.Size = new System.Drawing.Size(71, 26);
            this.gameTimeLeftLabel.TabIndex = 0;
            this.gameTimeLeftLabel.Text = "00:00";
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.Location = new System.Drawing.Point(3, 9);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(88, 24);
            this.timeLeftLabel.TabIndex = 1;
            this.timeLeftLabel.Text = "Tijd over:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gebruikte Power Ups:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.timeLeftLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gameTimeLeftLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 453);
            this.panel1.TabIndex = 3;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "GameMenu";
            this.Text = "Verstoppertje: In Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label gameTimeLeftLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}