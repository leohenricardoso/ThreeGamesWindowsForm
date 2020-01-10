namespace Prova
{
    partial class frmNickname
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.btnComecar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entre com seu Nickname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(46, 31);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(305, 20);
            this.txtNick.TabIndex = 2;
            this.txtNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(154, 66);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(75, 23);
            this.btnComecar.TabIndex = 3;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.BtnComecar_Click);
            // 
            // frmNickname
            // 
            this.AcceptButton = this.btnComecar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 101);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNickname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nickname";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Button btnComecar;
    }
}