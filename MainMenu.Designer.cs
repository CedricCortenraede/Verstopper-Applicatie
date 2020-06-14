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
            this.startGameAsHiderBtn = new System.Windows.Forms.Button();
            this.hideAndSeekLabel = new System.Windows.Forms.Label();
            this.gameRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.startGameAsSearcherBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameTimeNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimeNumber
            // 
            this.gameTimeNumber.Location = new System.Drawing.Point(1, 42);
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
            this.minutesLabel.Location = new System.Drawing.Point(42, 49);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(44, 13);
            this.minutesLabel.TabIndex = 3;
            this.minutesLabel.Text = "minuten";
            // 
            // gameRoleLabel
            // 
            this.gameRoleLabel.AutoSize = true;
            this.gameRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameRoleLabel.Location = new System.Drawing.Point(-2, 0);
            this.gameRoleLabel.Name = "gameRoleLabel";
            this.gameRoleLabel.Size = new System.Drawing.Size(30, 13);
            this.gameRoleLabel.TabIndex = 4;
            this.gameRoleLabel.Text = "Rol:";
            // 
            // startGameAsHiderBtn
            // 
            this.startGameAsHiderBtn.Location = new System.Drawing.Point(1, 76);
            this.startGameAsHiderBtn.Name = "startGameAsHiderBtn";
            this.startGameAsHiderBtn.Size = new System.Drawing.Size(247, 23);
            this.startGameAsHiderBtn.TabIndex = 5;
            this.startGameAsHiderBtn.Text = "Start het spel als verstopper";
            this.startGameAsHiderBtn.UseVisualStyleBackColor = true;
            this.startGameAsHiderBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // hideAndSeekLabel
            // 
            this.hideAndSeekLabel.AutoSize = true;
            this.hideAndSeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideAndSeekLabel.Location = new System.Drawing.Point(185, 9);
            this.hideAndSeekLabel.Name = "hideAndSeekLabel";
            this.hideAndSeekLabel.Size = new System.Drawing.Size(154, 26);
            this.hideAndSeekLabel.TabIndex = 8;
            this.hideAndSeekLabel.Text = "Verstoppertje";
            // 
            // gameRole
            // 
            this.gameRole.AutoSize = true;
            this.gameRole.Location = new System.Drawing.Point(28, 0);
            this.gameRole.Name = "gameRole";
            this.gameRole.Size = new System.Drawing.Size(58, 13);
            this.gameRole.TabIndex = 9;
            this.gameRole.Text = "Verstopper";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hoeveel tijd wil je voor het verstoppen?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gameRole);
            this.panel1.Controls.Add(this.gameTimeNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minutesLabel);
            this.panel1.Controls.Add(this.gameRoleLabel);
            this.panel1.Controls.Add(this.startGameAsHiderBtn);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 113);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(254, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 113);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Verstopper";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hoeveel tijd wil je voor het verstoppen?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "minuten";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start het spel als verstopper";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.startGameAsSearcherBtn);
            this.panel3.Location = new System.Drawing.Point(270, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 113);
            this.panel3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Zoeker";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(1, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 39);
            this.label11.TabIndex = 10;
            this.label11.Text = "Je hebt 60 seconden de tijd als zoeker om de verstopper te vinden. Let wel op, je" +
    " hebt maar 3 kansen om hem te vinden!\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Rol:";
            // 
            // startGameAsSearcherBtn
            // 
            this.startGameAsSearcherBtn.Location = new System.Drawing.Point(0, 76);
            this.startGameAsSearcherBtn.Name = "startGameAsSearcherBtn";
            this.startGameAsSearcherBtn.Size = new System.Drawing.Size(240, 23);
            this.startGameAsSearcherBtn.TabIndex = 5;
            this.startGameAsSearcherBtn.Text = "Start het spel als zoeker";
            this.startGameAsSearcherBtn.UseVisualStyleBackColor = true;
            this.startGameAsSearcherBtn.Click += new System.EventHandler(this.startGameAsSearcherBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 162);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.hideAndSeekLabel);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Text = "Verstoppertje: Menu";
            ((System.ComponentModel.ISupportInitialize)(this.gameTimeNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown gameTimeNumber;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label gameRoleLabel;
        private System.Windows.Forms.Button startGameAsHiderBtn;
        private System.Windows.Forms.Label hideAndSeekLabel;
        private System.Windows.Forms.Label gameRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button startGameAsSearcherBtn;
    }
}

