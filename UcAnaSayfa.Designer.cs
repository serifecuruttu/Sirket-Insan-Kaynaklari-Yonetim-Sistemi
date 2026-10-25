namespace insanKaynaklariYonetimSistemi
{
    partial class UcAnaSayfa
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSonIslemler = new System.Windows.Forms.DataGridView();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblİzinTalep = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEgitim = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.dgvSonIslemler);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnYenile);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 669);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblPersonel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(40, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 178);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblİzinTalep);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(261, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 178);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblEgitim);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(481, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 178);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.lblDepartman);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(705, 156);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 178);
            this.panel5.TabIndex = 3;
            // 
            // btnYenile
            // 
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYenile.Location = new System.Drawing.Point(709, 67);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(197, 51);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ana Sayfa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "İnsan Kaynakları Yönetim Sistemine Hoşgeldiniz.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toplam Personel";
            // 
            // dgvSonIslemler
            // 
            this.dgvSonIslemler.AllowUserToAddRows = false;
            this.dgvSonIslemler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSonIslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSonIslemler.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSonIslemler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSonIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonIslemler.Location = new System.Drawing.Point(40, 361);
            this.dgvSonIslemler.Name = "dgvSonIslemler";
            this.dgvSonIslemler.ReadOnly = true;
            this.dgvSonIslemler.RowHeadersVisible = false;
            this.dgvSonIslemler.RowHeadersWidth = 51;
            this.dgvSonIslemler.RowTemplate.Height = 24;
            this.dgvSonIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSonIslemler.Size = new System.Drawing.Size(888, 278);
            this.dgvSonIslemler.TabIndex = 7;
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(36, 84);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(15, 16);
            this.lblPersonel.TabIndex = 8;
            this.lblPersonel.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "İzin Talepleri";
            // 
            // lblİzinTalep
            // 
            this.lblİzinTalep.AutoSize = true;
            this.lblİzinTalep.Location = new System.Drawing.Point(35, 84);
            this.lblİzinTalep.Name = "lblİzinTalep";
            this.lblİzinTalep.Size = new System.Drawing.Size(15, 16);
            this.lblİzinTalep.TabIndex = 1;
            this.lblİzinTalep.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yaklaşan Eğitimler";
            // 
            // lblEgitim
            // 
            this.lblEgitim.AutoSize = true;
            this.lblEgitim.Location = new System.Drawing.Point(31, 84);
            this.lblEgitim.Name = "lblEgitim";
            this.lblEgitim.Size = new System.Drawing.Size(15, 16);
            this.lblEgitim.TabIndex = 1;
            this.lblEgitim.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Departmanlar";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Location = new System.Drawing.Point(30, 84);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(15, 16);
            this.lblDepartman.TabIndex = 1;
            this.lblDepartman.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(27, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Toplam çalışan sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bekleyen izinler";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(30, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Eğitim Sayısı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(29, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Departman Sayısı";
            // 
            // UcAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcAnaSayfa";
            this.Size = new System.Drawing.Size(967, 669);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonIslemler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSonIslemler;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Label lblEgitim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblİzinTalep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
