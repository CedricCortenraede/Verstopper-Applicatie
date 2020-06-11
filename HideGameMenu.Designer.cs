namespace Verstopper
{
    partial class HideGameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HideGameMenu));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimeLeftLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kamer1btn = new System.Windows.Forms.Button();
            this.kamer2btn = new System.Windows.Forms.Button();
            this.kamer3btn = new System.Windows.Forms.Button();
            this.kamer4btn = new System.Windows.Forms.Button();
            this.kamer5btn = new System.Windows.Forms.Button();
            this.kamer6btn = new System.Windows.Forms.Button();
            this.kamer8btn = new System.Windows.Forms.Button();
            this.kamer7btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.timeLeftLabel);
            this.panel1.Controls.Add(this.gameTimeLeftLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 421);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(220, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 421);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // kamer1btn
            // 
            this.kamer1btn.Location = new System.Drawing.Point(379, 48);
            this.kamer1btn.Name = "kamer1btn";
            this.kamer1btn.Size = new System.Drawing.Size(25, 23);
            this.kamer1btn.TabIndex = 5;
            this.kamer1btn.Text = "1";
            this.kamer1btn.UseVisualStyleBackColor = true;
            this.kamer1btn.Click += new System.EventHandler(this.kamer1btn_Click);
            // 
            // kamer2btn
            // 
            this.kamer2btn.Location = new System.Drawing.Point(379, 176);
            this.kamer2btn.Name = "kamer2btn";
            this.kamer2btn.Size = new System.Drawing.Size(25, 23);
            this.kamer2btn.TabIndex = 12;
            this.kamer2btn.Text = "2";
            this.kamer2btn.UseVisualStyleBackColor = true;
            this.kamer2btn.Click += new System.EventHandler(this.kamer2btn_Click);
            // 
            // kamer3btn
            // 
            this.kamer3btn.Location = new System.Drawing.Point(435, 299);
            this.kamer3btn.Name = "kamer3btn";
            this.kamer3btn.Size = new System.Drawing.Size(25, 23);
            this.kamer3btn.TabIndex = 13;
            this.kamer3btn.Text = "3";
            this.kamer3btn.UseVisualStyleBackColor = true;
            this.kamer3btn.Click += new System.EventHandler(this.kamer3btn_Click);
            // 
            // kamer4btn
            // 
            this.kamer4btn.Location = new System.Drawing.Point(520, 89);
            this.kamer4btn.Name = "kamer4btn";
            this.kamer4btn.Size = new System.Drawing.Size(25, 23);
            this.kamer4btn.TabIndex = 14;
            this.kamer4btn.Text = "4";
            this.kamer4btn.UseVisualStyleBackColor = true;
            this.kamer4btn.Click += new System.EventHandler(this.kamer4btn_Click);
            // 
            // kamer5btn
            // 
            this.kamer5btn.Location = new System.Drawing.Point(639, 89);
            this.kamer5btn.Name = "kamer5btn";
            this.kamer5btn.Size = new System.Drawing.Size(25, 23);
            this.kamer5btn.TabIndex = 15;
            this.kamer5btn.Text = "5";
            this.kamer5btn.UseVisualStyleBackColor = true;
            this.kamer5btn.Click += new System.EventHandler(this.kamer5btn_Click);
            // 
            // kamer6btn
            // 
            this.kamer6btn.Location = new System.Drawing.Point(533, 299);
            this.kamer6btn.Name = "kamer6btn";
            this.kamer6btn.Size = new System.Drawing.Size(25, 23);
            this.kamer6btn.TabIndex = 16;
            this.kamer6btn.Text = "6";
            this.kamer6btn.UseVisualStyleBackColor = true;
            this.kamer6btn.Click += new System.EventHandler(this.kamer6btn_Click);
            // 
            // kamer8btn
            // 
            this.kamer8btn.Location = new System.Drawing.Point(671, 220);
            this.kamer8btn.Name = "kamer8btn";
            this.kamer8btn.Size = new System.Drawing.Size(25, 23);
            this.kamer8btn.TabIndex = 17;
            this.kamer8btn.Text = "8";
            this.kamer8btn.UseVisualStyleBackColor = true;
            this.kamer8btn.Click += new System.EventHandler(this.kamer8btn_Click);
            // 
            // kamer7btn
            // 
            this.kamer7btn.Location = new System.Drawing.Point(614, 299);
            this.kamer7btn.Name = "kamer7btn";
            this.kamer7btn.Size = new System.Drawing.Size(25, 23);
            this.kamer7btn.TabIndex = 18;
            this.kamer7btn.Text = "7";
            this.kamer7btn.UseVisualStyleBackColor = true;
            this.kamer7btn.Click += new System.EventHandler(this.kamer7btn_Click);
            // 
            // HideGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.kamer7btn);
            this.Controls.Add(this.kamer8btn);
            this.Controls.Add(this.kamer6btn);
            this.Controls.Add(this.kamer5btn);
            this.Controls.Add(this.kamer4btn);
            this.Controls.Add(this.kamer3btn);
            this.Controls.Add(this.kamer2btn);
            this.Controls.Add(this.kamer1btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "HideGameMenu";
            this.Text = "Verstoppertje: Aan het verstoppen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label gameTimeLeftLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kamer1btn;
        private System.Windows.Forms.Button kamer2btn;
        private System.Windows.Forms.Button kamer3btn;
        private System.Windows.Forms.Button kamer4btn;
        private System.Windows.Forms.Button kamer5btn;
        private System.Windows.Forms.Button kamer6btn;
        private System.Windows.Forms.Button kamer8btn;
        private System.Windows.Forms.Button kamer7btn;
    }
}