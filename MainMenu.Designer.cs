namespace Verstopper
{
    partial class MainMenu
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
            this.gameTimeNumber = new System.Windows.Forms.NumericUpDown();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.gameRoleLabel = new System.Windows.Forms.Label();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.hideAndSeekLabel = new System.Windows.Forms.Label();
            this.gameRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameTimeNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimeNumber
            // 
            this.gameTimeNumber.Location = new System.Drawing.Point(12, 93);
            this.gameTimeNumber.Name = "gameTimeNumber";
            this.gameTimeNumber.Size = new System.Drawing.Size(35, 20);
            this.gameTimeNumber.TabIndex = 2;
            this.gameTimeNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(53, 100);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(44, 13);
            this.minutesLabel.TabIndex = 3;
            this.minutesLabel.Text = "minuten";
            // 
            // gameRoleLabel
            // 
            this.gameRoleLabel.AutoSize = true;
            this.gameRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameRoleLabel.Location = new System.Drawing.Point(9, 51);
            this.gameRoleLabel.Name = "gameRoleLabel";
            this.gameRoleLabel.Size = new System.Drawing.Size(30, 13);
            this.gameRoleLabel.TabIndex = 4;
            this.gameRoleLabel.Text = "Rol:";
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(12, 127);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(193, 23);
            this.startGameBtn.TabIndex = 5;
            this.startGameBtn.Text = "Start het spel";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // hideAndSeekLabel
            // 
            this.hideAndSeekLabel.AutoSize = true;
            this.hideAndSeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideAndSeekLabel.Location = new System.Drawing.Point(7, 9);
            this.hideAndSeekLabel.Name = "hideAndSeekLabel";
            this.hideAndSeekLabel.Size = new System.Drawing.Size(154, 26);
            this.hideAndSeekLabel.TabIndex = 8;
            this.hideAndSeekLabel.Text = "Verstoppertje";
            // 
            // gameRole
            // 
            this.gameRole.AutoSize = true;
            this.gameRole.Location = new System.Drawing.Point(39, 51);
            this.gameRole.Name = "gameRole";
            this.gameRole.Size = new System.Drawing.Size(58, 13);
            this.gameRole.TabIndex = 9;
            this.gameRole.Text = "Verstopper";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hoeveel tijd wil je voor het verstoppen?";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameRole);
            this.Controls.Add(this.hideAndSeekLabel);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.gameRoleLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.gameTimeNumber);
            this.Name = "MainMenu";
            this.Text = "Verstoppertje: Menu";
            ((System.ComponentModel.ISupportInitialize)(this.gameTimeNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown gameTimeNumber;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label gameRoleLabel;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Label hideAndSeekLabel;
        private System.Windows.Forms.Label gameRole;
        private System.Windows.Forms.Label label1;
    }
}

