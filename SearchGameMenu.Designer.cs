namespace Verstopper
{
    partial class SearchGameMenu
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
            this.startGameTimer = new System.Windows.Forms.Timer(this.components);
            this.checkHiderLocationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.gameTimeLeftLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGameTimer
            // 
            this.startGameTimer.Interval = 1000;
            this.startGameTimer.Tick += new System.EventHandler(this.startGameTimer_Tick);
            // 
            // checkHiderLocationTimer
            // 
            this.checkHiderLocationTimer.Interval = 1000;
            this.checkHiderLocationTimer.Tick += new System.EventHandler(this.checkHiderLocationTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.timeLeftLabel);
            this.panel1.Controls.Add(this.gameTimeLeftLabel);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 457);
            this.panel1.TabIndex = 4;
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.Location = new System.Drawing.Point(3, 9);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(178, 24);
            this.timeLeftLabel.TabIndex = 1;
            this.timeLeftLabel.Text = "Verstopper tijd over:";
            // 
            // gameTimeLeftLabel
            // 
            this.gameTimeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTimeLeftLabel.Location = new System.Drawing.Point(3, 33);
            this.gameTimeLeftLabel.Name = "gameTimeLeftLabel";
            this.gameTimeLeftLabel.Size = new System.Drawing.Size(200, 52);
            this.gameTimeLeftLabel.TabIndex = 0;
            this.gameTimeLeftLabel.Text = "Wachten op verstopper";
            // 
            // SearchGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SearchGameMenu";
            this.Text = "Verstoppertje: Aan het zoeken";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer startGameTimer;
        private System.Windows.Forms.Timer checkHiderLocationTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label gameTimeLeftLabel;
    }
}