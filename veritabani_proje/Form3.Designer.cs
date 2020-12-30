namespace veritabani_proje
{
    partial class frmSiparis
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
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtFaturaId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSiparisTarihi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSiparisId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriTablosu = new System.Windows.Forms.Button();
            this.btnKitapTablosu = new System.Windows.Forms.Button();
            this.cbxKargo = new System.Windows.Forms.ComboBox();
            this.cbxSatisTemsilcisi = new System.Windows.Forms.ComboBox();
            this.cbxMusteri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxKitap = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSiparisIdKitap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFiyatId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(555, 29);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(30, 23);
            this.btnAra.TabIndex = 27;
            this.btnAra.Text = "🔍";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(890, 191);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 35);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kargo Firması:";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.White;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(890, 108);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(127, 35);
            this.btnListele.TabIndex = 23;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(890, 149);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 35);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtFaturaId
            // 
            this.txtFaturaId.Location = new System.Drawing.Point(125, 94);
            this.txtFaturaId.Name = "txtFaturaId";
            this.txtFaturaId.Size = new System.Drawing.Size(147, 20);
            this.txtFaturaId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sipariş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(46, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fatura Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(60, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Müşteri:";
            // 
            // txtSiparisTarihi
            // 
            this.txtSiparisTarihi.Location = new System.Drawing.Point(125, 146);
            this.txtSiparisTarihi.Name = "txtSiparisTarihi";
            this.txtSiparisTarihi.Size = new System.Drawing.Size(147, 20);
            this.txtSiparisTarihi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Satış Temsilcisi:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtToplam);
            this.groupBox1.Controls.Add(this.cbxMusteri);
            this.groupBox1.Controls.Add(this.cbxSatisTemsilcisi);
            this.groupBox1.Controls.Add(this.cbxKargo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSiparisId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFaturaId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSiparisTarihi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(591, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 200);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Ekle";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(402, 32);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(147, 20);
            this.txtArama.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(47, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sipariş Id:";
            // 
            // txtSiparisId
            // 
            this.txtSiparisId.Location = new System.Drawing.Point(125, 15);
            this.txtSiparisId.Name = "txtSiparisId";
            this.txtSiparisId.Size = new System.Drawing.Size(147, 20);
            this.txtSiparisId.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 320);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(890, 235);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 35);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKategoriTablosu
            // 
            this.btnKategoriTablosu.BackColor = System.Drawing.Color.White;
            this.btnKategoriTablosu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriTablosu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKategoriTablosu.Location = new System.Drawing.Point(25, 384);
            this.btnKategoriTablosu.Name = "btnKategoriTablosu";
            this.btnKategoriTablosu.Size = new System.Drawing.Size(249, 35);
            this.btnKategoriTablosu.TabIndex = 28;
            this.btnKategoriTablosu.Text = "Kategori Tablosu";
            this.btnKategoriTablosu.UseVisualStyleBackColor = false;
            this.btnKategoriTablosu.Click += new System.EventHandler(this.btnKategoriTablosu_Click);
            // 
            // btnKitapTablosu
            // 
            this.btnKitapTablosu.BackColor = System.Drawing.Color.White;
            this.btnKitapTablosu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapTablosu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKitapTablosu.Location = new System.Drawing.Point(325, 384);
            this.btnKitapTablosu.Name = "btnKitapTablosu";
            this.btnKitapTablosu.Size = new System.Drawing.Size(260, 35);
            this.btnKitapTablosu.TabIndex = 29;
            this.btnKitapTablosu.Text = "Kitap Tablosu";
            this.btnKitapTablosu.UseVisualStyleBackColor = false;
            this.btnKitapTablosu.Click += new System.EventHandler(this.btnKitapTablosu_Click);
            // 
            // cbxKargo
            // 
            this.cbxKargo.FormattingEnabled = true;
            this.cbxKargo.Location = new System.Drawing.Point(125, 41);
            this.cbxKargo.Name = "cbxKargo";
            this.cbxKargo.Size = new System.Drawing.Size(147, 21);
            this.cbxKargo.TabIndex = 27;
            // 
            // cbxSatisTemsilcisi
            // 
            this.cbxSatisTemsilcisi.FormattingEnabled = true;
            this.cbxSatisTemsilcisi.Location = new System.Drawing.Point(125, 68);
            this.cbxSatisTemsilcisi.Name = "cbxSatisTemsilcisi";
            this.cbxSatisTemsilcisi.Size = new System.Drawing.Size(147, 21);
            this.cbxSatisTemsilcisi.TabIndex = 28;
            // 
            // cbxMusteri
            // 
            this.cbxMusteri.FormattingEnabled = true;
            this.cbxMusteri.Location = new System.Drawing.Point(125, 119);
            this.cbxMusteri.Name = "cbxMusteri";
            this.cbxMusteri.Size = new System.Drawing.Size(147, 21);
            this.cbxMusteri.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(224, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Müşteri Id\'ye göre arama:";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.White;
            this.btnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.Location = new System.Drawing.Point(890, 276);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(127, 35);
            this.btnKitapEkle.TabIndex = 32;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtMiktar);
            this.groupBox2.Controls.Add(this.cbxKitap);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSiparisIdKitap);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFiyatId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(591, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 124);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Ekle";
            // 
            // cbxKitap
            // 
            this.cbxKitap.FormattingEnabled = true;
            this.cbxKitap.Location = new System.Drawing.Point(125, 41);
            this.cbxKitap.Name = "cbxKitap";
            this.cbxKitap.Size = new System.Drawing.Size(147, 21);
            this.cbxKitap.TabIndex = 27;
            this.cbxKitap.SelectedValueChanged += new System.EventHandler(this.cbxKitap_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(43, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sipariş Id:";
            // 
            // txtSiparisIdKitap
            // 
            this.txtSiparisIdKitap.Location = new System.Drawing.Point(125, 15);
            this.txtSiparisIdKitap.Name = "txtSiparisIdKitap";
            this.txtSiparisIdKitap.Size = new System.Drawing.Size(147, 20);
            this.txtSiparisIdKitap.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(72, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kitap:";
            // 
            // txtFiyatId
            // 
            this.txtFiyatId.Location = new System.Drawing.Point(125, 94);
            this.txtFiyatId.Name = "txtFiyatId";
            this.txtFiyatId.Size = new System.Drawing.Size(147, 20);
            this.txtFiyatId.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(53, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Fiyat Id:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(60, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "Miktar:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(125, 68);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(147, 20);
            this.txtMiktar.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(20, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Toplam Tutar:";
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(125, 171);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(147, 20);
            this.txtToplam.TabIndex = 31;
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1031, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKitapTablosu);
            this.Controls.Add(this.btnKategoriTablosu);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "frmSiparis";
            this.Text = "Siparis";
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtFaturaId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSiparisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSiparisId;
        private System.Windows.Forms.Button btnKategoriTablosu;
        private System.Windows.Forms.Button btnKitapTablosu;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cbxMusteri;
        private System.Windows.Forms.ComboBox cbxSatisTemsilcisi;
        private System.Windows.Forms.ComboBox cbxKargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.ComboBox cbxKitap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSiparisIdKitap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFiyatId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtToplam;
    }
}