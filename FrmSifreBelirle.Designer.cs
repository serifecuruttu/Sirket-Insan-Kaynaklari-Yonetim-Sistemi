namespace insanKaynaklariYonetimSistemi
{
    partial class FrmSifreBelirle
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
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnSifreBelirle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSifreSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Location = new System.Drawing.Point(18, 95);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(177, 26);
            this.txtYeniSifre.TabIndex = 0;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreTekrar.Location = new System.Drawing.Point(23, 172);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(172, 26);
            this.txtSifreTekrar.TabIndex = 1;
            // 
            // btnSifreBelirle
            // 
            this.btnSifreBelirle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreBelirle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreBelirle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSifreBelirle.Location = new System.Drawing.Point(12, 231);
            this.btnSifreBelirle.Name = "btnSifreBelirle";
            this.btnSifreBelirle.Size = new System.Drawing.Size(428, 39);
            this.btnSifreBelirle.TabIndex = 2;
            this.btnSifreBelirle.Text = "Şifre Oluştur";
            this.btnSifreBelirle.UseVisualStyleBackColor = true;
            this.btnSifreBelirle.Click += new System.EventHandler(this.btnSifreBelirle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şifre Belirleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yeni Şifre Tekrar:";
            // 
            // lblSifreSonuc
            // 
            this.lblSifreSonuc.AutoSize = true;
            this.lblSifreSonuc.Location = new System.Drawing.Point(20, 293);
            this.lblSifreSonuc.Name = "lblSifreSonuc";
            this.lblSifreSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSifreSonuc.TabIndex = 6;
            // 
            // FrmSifreBelirle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(452, 328);
            this.Controls.Add(this.lblSifreSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSifreBelirle);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtYeniSifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSifreBelirle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSifreBelirle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Button btnSifreBelirle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSifreSonuc;
    }
}