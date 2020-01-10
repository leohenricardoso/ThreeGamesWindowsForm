namespace Prova
{
    partial class frmNicknamePong
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
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnComecarPong = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(24, 22);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(62, 17);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Jogador 1:";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(24, 60);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(64, 17);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Jogador 2:";
            // 
            // btnComecarPong
            // 
            this.btnComecarPong.Location = new System.Drawing.Point(131, 105);
            this.btnComecarPong.Name = "btnComecarPong";
            this.btnComecarPong.Size = new System.Drawing.Size(87, 32);
            this.btnComecarPong.TabIndex = 2;
            this.btnComecarPong.Text = "Começar";
            this.btnComecarPong.UseVisualStyleBackColor = true;
            this.btnComecarPong.Click += new System.EventHandler(this.BtnComecarPong_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(111, 20);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(187, 20);
            this.txtPlayer1.TabIndex = 3;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(111, 58);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(187, 20);
            this.txtPlayer2.TabIndex = 4;
            // 
            // frmNicknamePong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 157);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.btnComecarPong);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNicknamePong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nome dos jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnComecarPong;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
    }
}