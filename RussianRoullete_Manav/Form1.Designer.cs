namespace RussianRoullete_Manav
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGamePoints = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureLoadGun = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PlayAgainbtn = new System.Windows.Forms.Button();
            this.ShootawayBtn = new System.Windows.Forms.Button();
            this.ShootheadBtn = new System.Windows.Forms.Button();
            this.SpinChamberBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LoadBulletBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoadGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Russian Roullete";
            // 
            // txtGamePoints
            // 
            this.txtGamePoints.Location = new System.Drawing.Point(27, 161);
            this.txtGamePoints.Name = "txtGamePoints";
            this.txtGamePoints.Size = new System.Drawing.Size(200, 22);
            this.txtGamePoints.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Points";
            // 
            // pictureLoadGun
            // 
            this.pictureLoadGun.Location = new System.Drawing.Point(27, 220);
            this.pictureLoadGun.Name = "pictureLoadGun";
            this.pictureLoadGun.Size = new System.Drawing.Size(200, 120);
            this.pictureLoadGun.TabIndex = 3;
            this.pictureLoadGun.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RussianRoullete_Manav.Properties.Resources.b5;
            this.pictureBox2.Location = new System.Drawing.Point(27, 358);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 163);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // PlayAgainbtn
            // 
            this.PlayAgainbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayAgainbtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainbtn.Location = new System.Drawing.Point(687, 352);
            this.PlayAgainbtn.Name = "PlayAgainbtn";
            this.PlayAgainbtn.Size = new System.Drawing.Size(140, 51);
            this.PlayAgainbtn.TabIndex = 19;
            this.PlayAgainbtn.Text = "Play Again";
            this.PlayAgainbtn.UseVisualStyleBackColor = false;
            this.PlayAgainbtn.Click += new System.EventHandler(this.PlayAgainbtn_Click);
            // 
            // ShootawayBtn
            // 
            this.ShootawayBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShootawayBtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootawayBtn.Location = new System.Drawing.Point(687, 248);
            this.ShootawayBtn.Name = "ShootawayBtn";
            this.ShootawayBtn.Size = new System.Drawing.Size(140, 51);
            this.ShootawayBtn.TabIndex = 18;
            this.ShootawayBtn.Text = "Shoot Away";
            this.ShootawayBtn.UseVisualStyleBackColor = false;
            this.ShootawayBtn.Click += new System.EventHandler(this.ShootawayBtn_Click);
            // 
            // ShootheadBtn
            // 
            this.ShootheadBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShootheadBtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootheadBtn.Location = new System.Drawing.Point(687, 191);
            this.ShootheadBtn.Name = "ShootheadBtn";
            this.ShootheadBtn.Size = new System.Drawing.Size(140, 51);
            this.ShootheadBtn.TabIndex = 17;
            this.ShootheadBtn.Text = "Shoot At Head";
            this.ShootheadBtn.UseVisualStyleBackColor = false;
            this.ShootheadBtn.Click += new System.EventHandler(this.ShootheadBtn_Click);
            // 
            // SpinChamberBtn
            // 
            this.SpinChamberBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpinChamberBtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinChamberBtn.Location = new System.Drawing.Point(687, 139);
            this.SpinChamberBtn.Name = "SpinChamberBtn";
            this.SpinChamberBtn.Size = new System.Drawing.Size(140, 46);
            this.SpinChamberBtn.TabIndex = 16;
            this.SpinChamberBtn.Text = "Spin Chamber";
            this.SpinChamberBtn.UseVisualStyleBackColor = false;
            this.SpinChamberBtn.Click += new System.EventHandler(this.SpinChamberBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitBtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(687, 409);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(140, 49);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LoadBulletBtn
            // 
            this.LoadBulletBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadBulletBtn.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBulletBtn.Location = new System.Drawing.Point(687, 81);
            this.LoadBulletBtn.Name = "LoadBulletBtn";
            this.LoadBulletBtn.Size = new System.Drawing.Size(140, 41);
            this.LoadBulletBtn.TabIndex = 14;
            this.LoadBulletBtn.Text = "Load Bullet";
            this.LoadBulletBtn.UseVisualStyleBackColor = false;
            this.LoadBulletBtn.Click += new System.EventHandler(this.LoadBulletBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRoullete_Manav.Properties.Resources.b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 533);
            this.Controls.Add(this.PlayAgainbtn);
            this.Controls.Add(this.ShootawayBtn);
            this.Controls.Add(this.ShootheadBtn);
            this.Controls.Add(this.SpinChamberBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoadBulletBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureLoadGun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGamePoints);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Main Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoadGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGamePoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureLoadGun;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button PlayAgainbtn;
        private System.Windows.Forms.Button ShootawayBtn;
        private System.Windows.Forms.Button ShootheadBtn;
        private System.Windows.Forms.Button SpinChamberBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LoadBulletBtn;
    }
}

