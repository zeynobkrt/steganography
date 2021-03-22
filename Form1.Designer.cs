namespace Steganografi_bitirme
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.picIsleme = new System.Windows.Forms.PictureBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCoz = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btn_gizle = new System.Windows.Forms.Button();
            this.btn_ac = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sifre_Coz = new System.Windows.Forms.Button();
            this.btn_Sifrele = new System.Windows.Forms.Button();
            this.btn2_Ac = new System.Windows.Forms.Button();
            this.combo_seviye = new System.Windows.Forms.ComboBox();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_anahtar = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSayi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIsleme)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picIsleme
            // 
            this.picIsleme.Location = new System.Drawing.Point(12, 12);
            this.picIsleme.Name = "picIsleme";
            this.picIsleme.Size = new System.Drawing.Size(321, 325);
            this.picIsleme.TabIndex = 0;
            this.picIsleme.TabStop = false;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(362, 12);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(267, 49);
            this.txtMesaj.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCoz);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btn_gizle);
            this.groupBox1.Controls.Add(this.btn_ac);
            this.groupBox1.Location = new System.Drawing.Point(362, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "stego_lsb";
            // 
            // btnCoz
            // 
            this.btnCoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCoz.Location = new System.Drawing.Point(249, 34);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(75, 23);
            this.btnCoz.TabIndex = 3;
            this.btnCoz.Text = "Çöz";
            this.btnCoz.UseVisualStyleBackColor = false;
            this.btnCoz.Click += new System.EventHandler(this.btnCoz_Click_1);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKaydet.Location = new System.Drawing.Point(168, 34);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // btn_gizle
            // 
            this.btn_gizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_gizle.Location = new System.Drawing.Point(87, 34);
            this.btn_gizle.Name = "btn_gizle";
            this.btn_gizle.Size = new System.Drawing.Size(75, 23);
            this.btn_gizle.TabIndex = 1;
            this.btn_gizle.Text = "Gizle";
            this.btn_gizle.UseVisualStyleBackColor = false;
            this.btn_gizle.Click += new System.EventHandler(this.btn_gizle_Click_1);
            // 
            // btn_ac
            // 
            this.btn_ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ac.Location = new System.Drawing.Point(6, 34);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(75, 23);
            this.btn_ac.TabIndex = 0;
            this.btn_ac.Text = "Aç";
            this.btn_ac.UseVisualStyleBackColor = false;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Sifre_Coz);
            this.groupBox2.Controls.Add(this.btn_Sifrele);
            this.groupBox2.Controls.Add(this.btn2_Ac);
            this.groupBox2.Controls.Add(this.combo_seviye);
            this.groupBox2.Controls.Add(this.txtAnahtar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_anahtar);
            this.groupBox2.Location = new System.Drawing.Point(362, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "stego_algoritmalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // btn_Sifre_Coz
            // 
            this.btn_Sifre_Coz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Sifre_Coz.Location = new System.Drawing.Point(171, 92);
            this.btn_Sifre_Coz.Name = "btn_Sifre_Coz";
            this.btn_Sifre_Coz.Size = new System.Drawing.Size(75, 23);
            this.btn_Sifre_Coz.TabIndex = 6;
            this.btn_Sifre_Coz.Text = "Şifreyi Çöz";
            this.btn_Sifre_Coz.UseVisualStyleBackColor = false;
            this.btn_Sifre_Coz.Click += new System.EventHandler(this.btn_Sifre_Coz_Click_1);
            // 
            // btn_Sifrele
            // 
            this.btn_Sifrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Sifrele.Location = new System.Drawing.Point(90, 92);
            this.btn_Sifrele.Name = "btn_Sifrele";
            this.btn_Sifrele.Size = new System.Drawing.Size(75, 23);
            this.btn_Sifrele.TabIndex = 5;
            this.btn_Sifrele.Text = "Şifrele";
            this.btn_Sifrele.UseVisualStyleBackColor = false;
            this.btn_Sifrele.Click += new System.EventHandler(this.btn_Sifrele_Click_1);
            // 
            // btn2_Ac
            // 
            this.btn2_Ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn2_Ac.Location = new System.Drawing.Point(9, 92);
            this.btn2_Ac.Name = "btn2_Ac";
            this.btn2_Ac.Size = new System.Drawing.Size(75, 23);
            this.btn2_Ac.TabIndex = 4;
            this.btn2_Ac.Text = "Aç";
            this.btn2_Ac.UseVisualStyleBackColor = false;
            this.btn2_Ac.Click += new System.EventHandler(this.btn2_Ac_Click_1);
            // 
            // combo_seviye
            // 
            this.combo_seviye.FormattingEnabled = true;
            this.combo_seviye.Items.AddRange(new object[] {
            "",
            "1",
            "2"});
            this.combo_seviye.Location = new System.Drawing.Point(62, 50);
            this.combo_seviye.Name = "combo_seviye";
            this.combo_seviye.Size = new System.Drawing.Size(61, 21);
            this.combo_seviye.TabIndex = 3;
            this.combo_seviye.SelectedIndexChanged += new System.EventHandler(this.combo_seviye_SelectedIndexChanged_1);
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(62, 23);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(148, 20);
            this.txtAnahtar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seviye:";
            // 
            // lbl_anahtar
            // 
            this.lbl_anahtar.AutoSize = true;
            this.lbl_anahtar.Location = new System.Drawing.Point(6, 26);
            this.lbl_anahtar.Name = "lbl_anahtar";
            this.lbl_anahtar.Size = new System.Drawing.Size(47, 13);
            this.lbl_anahtar.TabIndex = 0;
            this.lbl_anahtar.Text = "Anahtar:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSayi,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(729, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSayi
            // 
            this.toolStripSayi.Name = "toolStripSayi";
            this.toolStripSayi.Size = new System.Drawing.Size(13, 17);
            this.toolStripSayi.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabel2.Text = "Karakter Gizlenebilir";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(635, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Çıkış Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(729, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.picIsleme);
            this.Name = "Form1";
            this.Text = "Steganografi Aracı - Zeynep Bakırtemizler";
            ((System.ComponentModel.ISupportInitialize)(this.picIsleme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIsleme;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCoz;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btn_gizle;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Sifre_Coz;
        private System.Windows.Forms.Button btn_Sifrele;
        private System.Windows.Forms.Button btn2_Ac;
        private System.Windows.Forms.ComboBox combo_seviye;
        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_anahtar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSayi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button1;
    }
}

