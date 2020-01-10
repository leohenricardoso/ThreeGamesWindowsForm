namespace Prova
{
    partial class frmMenuPrincipal
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
            this.btnCarRacing = new System.Windows.Forms.Button();
            this.btnPingPong = new System.Windows.Forms.Button();
            this.btnFuga = new System.Windows.Forms.Button();
            this.btnPlacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarRacing
            // 
            this.btnCarRacing.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCarRacing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCarRacing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarRacing.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarRacing.Location = new System.Drawing.Point(-2, 215);
            this.btnCarRacing.Name = "btnCarRacing";
            this.btnCarRacing.Size = new System.Drawing.Size(385, 104);
            this.btnCarRacing.TabIndex = 0;
            this.btnCarRacing.Text = "Jogo do Car Racing";
            this.btnCarRacing.UseVisualStyleBackColor = false;
            this.btnCarRacing.Click += new System.EventHandler(this.BtnCarRacing_Click);
            // 
            // btnPingPong
            // 
            this.btnPingPong.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPingPong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPingPong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPingPong.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPingPong.Location = new System.Drawing.Point(-2, 106);
            this.btnPingPong.Name = "btnPingPong";
            this.btnPingPong.Size = new System.Drawing.Size(385, 103);
            this.btnPingPong.TabIndex = 1;
            this.btnPingPong.Text = "Jogo Ping Pong";
            this.btnPingPong.UseVisualStyleBackColor = false;
            this.btnPingPong.Click += new System.EventHandler(this.BtnPingPong_Click);
            // 
            // btnFuga
            // 
            this.btnFuga.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFuga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFuga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuga.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuga.Location = new System.Drawing.Point(-2, 1);
            this.btnFuga.Name = "btnFuga";
            this.btnFuga.Size = new System.Drawing.Size(385, 99);
            this.btnFuga.TabIndex = 2;
            this.btnFuga.Text = "Jogo Fuja da bolinha";
            this.btnFuga.UseVisualStyleBackColor = false;
            this.btnFuga.Click += new System.EventHandler(this.BtnFuga_Click);
            // 
            // btnPlacar
            // 
            this.btnPlacar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPlacar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlacar.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlacar.Location = new System.Drawing.Point(-2, 325);
            this.btnPlacar.Name = "btnPlacar";
            this.btnPlacar.Size = new System.Drawing.Size(385, 124);
            this.btnPlacar.TabIndex = 3;
            this.btnPlacar.Text = "Ver Placar de Scores";
            this.btnPlacar.UseVisualStyleBackColor = false;
            this.btnPlacar.Click += new System.EventHandler(this.BtnPlacar_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AcceptButton = this.btnPlacar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnPlacar);
            this.Controls.Add(this.btnFuga);
            this.Controls.Add(this.btnPingPong);
            this.Controls.Add(this.btnCarRacing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarRacing;
        private System.Windows.Forms.Button btnPingPong;
        private System.Windows.Forms.Button btnFuga;
        private System.Windows.Forms.Button btnPlacar;
    }
}