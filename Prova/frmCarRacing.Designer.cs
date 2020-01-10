namespace Prova
{
    partial class frmCarRacing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarRacing));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.gameOver = new System.Windows.Forms.Label();
            this.point1 = new System.Windows.Forms.PictureBox();
            this.point2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblNick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(188, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(188, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 85);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(188, 252);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 81);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(188, 384);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 92);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(0, -4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 493);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(373, -17);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 493);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(114, 372);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(27, 55);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 6;
            this.car.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(73, 121);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(27, 55);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(229, 61);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(27, 55);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 8;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(315, 193);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(27, 55);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 9;
            this.enemy3.TabStop = false;
            // 
            // gameOver
            // 
            this.gameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameOver.AutoSize = true;
            this.gameOver.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.Location = new System.Drawing.Point(107, 209);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(167, 34);
            this.gameOver.TabIndex = 10;
            this.gameOver.Text = "VOCÊ PERDEU";
            this.gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOver.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // point1
            // 
            this.point1.BackColor = System.Drawing.Color.Transparent;
            this.point1.Location = new System.Drawing.Point(8, 166);
            this.point1.Name = "point1";
            this.point1.Size = new System.Drawing.Size(364, 10);
            this.point1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.point1.TabIndex = 11;
            this.point1.TabStop = false;
            // 
            // point2
            // 
            this.point2.BackColor = System.Drawing.Color.Transparent;
            this.point2.Location = new System.Drawing.Point(8, 433);
            this.point2.Name = "point2";
            this.point2.Size = new System.Drawing.Size(364, 10);
            this.point2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.point2.TabIndex = 12;
            this.point2.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScore.Location = new System.Drawing.Point(16, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(59, 19);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "Score: 0";
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(133, 295);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(114, 19);
            this.lblPause.TabIndex = 14;
            this.lblPause.Text = "Pressione Space";
            this.lblPause.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Orange;
            this.btnReiniciar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(114, 252);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(152, 40);
            this.btnReiniciar.TabIndex = 15;
            this.btnReiniciar.Text = "Voltar ao Menu";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(17, 28);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(35, 13);
            this.lblNick.TabIndex = 16;
            this.lblNick.Text = "Nick: ";
            // 
            // frmCarRacing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.car);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.point1);
            this.Controls.Add(this.point2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarRacing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corrida de Carro";
            this.Click += new System.EventHandler(this.BtnReiniciar_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCarRacing_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.PictureBox point1;
        private System.Windows.Forms.PictureBox point2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblNick;
    }
}

