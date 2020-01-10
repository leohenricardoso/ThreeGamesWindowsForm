using System.Windows.Forms;

namespace Prova
{
    partial class frmPong
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(200, 171);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(544, 56);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Player 1 vs Player 2";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreLabel.Visible = false;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPress.Location = new System.Drawing.Point(242, 132);
            this.lblPress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(515, 39);
            this.lblPress.TabIndex = 1;
            this.lblPress.Text = "Pressione espaço para começar";
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(238, 9);
            this.lblPause.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(523, 39);
            this.lblPause.TabIndex = 2;
            this.lblPause.Text = "Pressione espaço para continuar";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(374, 88);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(251, 60);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "Fim de Jogo";
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.BackColor = System.Drawing.Color.Salmon;
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.Location = new System.Drawing.Point(420, 249);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(131, 45);
            this.btnVoltarMenu.TabIndex = 4;
            this.btnVoltarMenu.Text = "Voltar ao Menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = false;
            this.btnVoltarMenu.Click += new System.EventHandler(this.BtnVoltarMenu_Click);
            // 
            // frmPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblPress);
            this.Controls.Add(this.scoreLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PongGame";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PongForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pongForm_sobeBola);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JogoPong_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pongForm_desceBola);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label scoreLabel;
        private Label lblPress;
        private Label lblPause;
        private Timer timer1;
        private Label lblGameOver;
        private Button btnVoltarMenu;
    }
}