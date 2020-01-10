using System;
using System.Collections.Generic;

namespace Prova
{
    partial class TelaInicial
    {

        private int totalBolas = 0;

        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmpBolaDeFogo = new System.Windows.Forms.Timer(this.components);
            this.tmBonecoAndar = new System.Windows.Forms.Timer(this.components);
            this.tmBordasPersonagem = new System.Windows.Forms.Timer(this.components);
            this.tmAumentaNivel = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbNick = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreBolinha = new System.Windows.Forms.Label();
            this.tmScore = new System.Windows.Forms.Timer(this.components);
            this.imgDir = new System.Windows.Forms.PictureBox();
            this.imgEsq = new System.Windows.Forms.PictureBox();
            this.imgRodape = new System.Windows.Forms.PictureBox();
            this.imgTopo = new System.Windows.Forms.PictureBox();
            this.Boneco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEsq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRodape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTopo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boneco)).BeginInit();
            this.SuspendLayout();
            // 
            // tmpBolaDeFogo
            // 
            this.tmpBolaDeFogo.Enabled = true;
            this.tmpBolaDeFogo.Tick += new System.EventHandler(this.TmpBolaDeFogo_Tick);
            // 
            // tmBonecoAndar
            // 
            this.tmBonecoAndar.Enabled = true;
            this.tmBonecoAndar.Interval = 10;
            this.tmBonecoAndar.Tick += new System.EventHandler(this.TmBonecoAndar_Tick);
            // 
            // tmBordasPersonagem
            // 
            this.tmBordasPersonagem.Enabled = true;
            this.tmBordasPersonagem.Interval = 50;
            this.tmBordasPersonagem.Tick += new System.EventHandler(this.TmBordasPersonagem_Tick);
            // 
            // tmAumentaNivel
            // 
            this.tmAumentaNivel.Enabled = true;
            this.tmAumentaNivel.Interval = 10000;
            this.tmAumentaNivel.Tick += new System.EventHandler(this.TmAumentaNivel_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jogador:";
            // 
            // lbNick
            // 
            this.lbNick.AutoSize = true;
            this.lbNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNick.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNick.Location = new System.Drawing.Point(165, 14);
            this.lbNick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNick.Name = "lbNick";
            this.lbNick.Size = new System.Drawing.Size(119, 33);
            this.lbNick.TabIndex = 7;
            this.lbNick.Text = "jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(654, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "SCORE:";
            // 
            // scoreBolinha
            // 
            this.scoreBolinha.AutoSize = true;
            this.scoreBolinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBolinha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreBolinha.Location = new System.Drawing.Point(794, 14);
            this.scoreBolinha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreBolinha.Name = "scoreBolinha";
            this.scoreBolinha.Size = new System.Drawing.Size(123, 33);
            this.scoreBolinha.TabIndex = 9;
            this.scoreBolinha.Text = "SCORE";
            // 
            // tmScore
            // 
            this.tmScore.Enabled = true;
            this.tmScore.Interval = 1000;
            this.tmScore.Tick += new System.EventHandler(this.TmScore_Tick);
            // 
            // imgDir
            // 
            this.imgDir.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgDir.Image = global::Prova.Properties.Resources.paredeV;
            this.imgDir.Location = new System.Drawing.Point(1152, 62);
            this.imgDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgDir.Name = "imgDir";
            this.imgDir.Size = new System.Drawing.Size(60, 550);
            this.imgDir.TabIndex = 5;
            this.imgDir.TabStop = false;
            this.imgDir.Paint += new System.Windows.Forms.PaintEventHandler(this.ImgDir_Paint);
            // 
            // imgEsq
            // 
            this.imgEsq.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgEsq.Image = global::Prova.Properties.Resources.paredeV;
            this.imgEsq.Location = new System.Drawing.Point(0, 62);
            this.imgEsq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgEsq.Name = "imgEsq";
            this.imgEsq.Size = new System.Drawing.Size(60, 550);
            this.imgEsq.TabIndex = 4;
            this.imgEsq.TabStop = false;
            this.imgEsq.Paint += new System.Windows.Forms.PaintEventHandler(this.ImgEsq_Paint);
            // 
            // imgRodape
            // 
            this.imgRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imgRodape.Image = global::Prova.Properties.Resources.paredeH;
            this.imgRodape.Location = new System.Drawing.Point(0, 612);
            this.imgRodape.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgRodape.Name = "imgRodape";
            this.imgRodape.Size = new System.Drawing.Size(1212, 62);
            this.imgRodape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRodape.TabIndex = 3;
            this.imgRodape.TabStop = false;
            this.imgRodape.Paint += new System.Windows.Forms.PaintEventHandler(this.ImgRodape_Paint);
            // 
            // imgTopo
            // 
            this.imgTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgTopo.Image = global::Prova.Properties.Resources.paredeH;
            this.imgTopo.Location = new System.Drawing.Point(0, 0);
            this.imgTopo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgTopo.Name = "imgTopo";
            this.imgTopo.Size = new System.Drawing.Size(1212, 62);
            this.imgTopo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTopo.TabIndex = 2;
            this.imgTopo.TabStop = false;
            this.imgTopo.Paint += new System.Windows.Forms.PaintEventHandler(this.ImgTopo_Paint);
            // 
            // Boneco
            // 
            this.Boneco.BackColor = System.Drawing.Color.Transparent;
            this.Boneco.Image = global::Prova.Properties.Resources.char_down_1;
            this.Boneco.Location = new System.Drawing.Point(490, 62);
            this.Boneco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Boneco.Name = "Boneco";
            this.Boneco.Size = new System.Drawing.Size(72, 60);
            this.Boneco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Boneco.TabIndex = 1;
            this.Boneco.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1212, 674);
            this.Controls.Add(this.scoreBolinha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgDir);
            this.Controls.Add(this.imgEsq);
            this.Controls.Add(this.imgRodape);
            this.Controls.Add(this.imgTopo);
            this.Controls.Add(this.Boneco);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "Fuja Do Fogo!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaInicial_KeyDown);
            this.Resize += new System.EventHandler(this.TelaInicial_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imgDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEsq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRodape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTopo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boneco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmpBolaDeFogo;
        private System.Windows.Forms.PictureBox Boneco;
        private System.Windows.Forms.Timer tmBonecoAndar;
        private System.Windows.Forms.Timer tmBordasPersonagem;
        private System.Windows.Forms.Timer tmAumentaNivel;
        private System.Windows.Forms.PictureBox imgTopo;
        private System.Windows.Forms.PictureBox imgRodape;
        private System.Windows.Forms.PictureBox imgEsq;
        private System.Windows.Forms.PictureBox imgDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scoreBolinha;
        private System.Windows.Forms.Timer tmScore;
    }
}

