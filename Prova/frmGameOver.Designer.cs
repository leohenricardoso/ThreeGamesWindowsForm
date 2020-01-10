namespace Prova
{
    partial class frmGameOver
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
            this.pcbFechar = new System.Windows.Forms.PictureBox();
            this.lblFechar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbFechar
            // 
            this.pcbFechar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbFechar.Image = global::Prova.Properties.Resources.zelda;
            this.pcbFechar.Location = new System.Drawing.Point(5, 5);
            this.pcbFechar.Name = "pcbFechar";
            this.pcbFechar.Size = new System.Drawing.Size(773, 557);
            this.pcbFechar.TabIndex = 0;
            this.pcbFechar.TabStop = false;
            this.pcbFechar.Click += new System.EventHandler(this.pcbFechar_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.BackColor = System.Drawing.Color.Black;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(234, 278);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(310, 37);
            this.lblFechar.TabIndex = 1;
            this.lblFechar.Text = "Voltar para o menu";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(783, 567);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.pcbFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGameOver";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGameOver";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFechar;
        private System.Windows.Forms.Label lblFechar;
    }
}