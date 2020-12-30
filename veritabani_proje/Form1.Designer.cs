namespace veritabani_proje
{
    partial class frmKitap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStokAdedi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtKitapArkasi = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.txtFotograf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxYayinevi = new System.Windows.Forms.ComboBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.txtFiyatId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSiparisTablosu = new System.Windows.Forms.Button();
            this.btnKategoriTablosu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 266);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(120, 64);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(147, 20);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yayınevi:";
            // 
            // txtStokAdedi
            // 
            this.txtStokAdedi.Location = new System.Drawing.Point(120, 195);
            this.txtStokAdedi.Name = "txtStokAdedi";
            this.txtStokAdedi.Size = new System.Drawing.Size(147, 20);
            this.txtStokAdedi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(31, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stok Adedi:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(120, 169);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(147, 20);
            this.txtSayfaSayisi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(25, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(120, 143);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(147, 20);
            this.txtYazar.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(65, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Yazar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kitap Arkası:";
            // 
            // rtxtKitapArkasi
            // 
            this.rtxtKitapArkasi.Location = new System.Drawing.Point(120, 273);
            this.rtxtKitapArkasi.Name = "rtxtKitapArkasi";
            this.rtxtKitapArkasi.Size = new System.Drawing.Size(147, 109);
            this.rtxtKitapArkasi.TabIndex = 14;
            this.rtxtKitapArkasi.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKitapId);
            this.groupBox1.Controls.Add(this.txtFotograf);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbxYayinevi);
            this.groupBox1.Controls.Add(this.cbxKategori);
            this.groupBox1.Controls.Add(this.txtFiyatId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rtxtKitapArkasi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSayfaSayisi);
            this.groupBox1.Controls.Add(this.txtStokAdedi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(913, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 403);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(50, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Kitap Id:";
            // 
            // txtKitapId
            // 
            this.txtKitapId.Location = new System.Drawing.Point(120, 38);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.Size = new System.Drawing.Size(147, 20);
            this.txtKitapId.TabIndex = 22;
            // 
            // txtFotograf
            // 
            this.txtFotograf.Location = new System.Drawing.Point(120, 247);
            this.txtFotograf.Name = "txtFotograf";
            this.txtFotograf.Size = new System.Drawing.Size(147, 20);
            this.txtFotograf.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(49, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fotoğraf:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbxYayinevi
            // 
            this.cbxYayinevi.FormattingEnabled = true;
            this.cbxYayinevi.Location = new System.Drawing.Point(120, 116);
            this.cbxYayinevi.Name = "cbxYayinevi";
            this.cbxYayinevi.Size = new System.Drawing.Size(146, 21);
            this.cbxYayinevi.TabIndex = 18;
            // 
            // cbxKategori
            // 
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(120, 89);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(147, 21);
            this.cbxKategori.TabIndex = 17;
            // 
            // txtFiyatId
            // 
            this.txtFiyatId.Location = new System.Drawing.Point(120, 221);
            this.txtFiyatId.Name = "txtFiyatId";
            this.txtFiyatId.Size = new System.Drawing.Size(147, 20);
            this.txtFiyatId.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(52, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fiyat Id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(598, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ada göre arama:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(723, 24);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(147, 20);
            this.txtArama.TabIndex = 24;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.White;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(1216, 76);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(127, 35);
            this.btnListele.TabIndex = 16;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(1216, 117);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 35);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1216, 159);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 35);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(1216, 203);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 35);
            this.btnGuncelle.TabIndex = 19;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(876, 22);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(32, 23);
            this.btnAra.TabIndex = 20;
            this.btnAra.Text = "🔍";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSiparisTablosu
            // 
            this.btnSiparisTablosu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSiparisTablosu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisTablosu.Location = new System.Drawing.Point(573, 322);
            this.btnSiparisTablosu.Name = "btnSiparisTablosu";
            this.btnSiparisTablosu.Size = new System.Drawing.Size(233, 35);
            this.btnSiparisTablosu.TabIndex = 22;
            this.btnSiparisTablosu.Text = "Siparis Tablosu";
            this.btnSiparisTablosu.UseVisualStyleBackColor = false;
            this.btnSiparisTablosu.Click += new System.EventHandler(this.btnYayineviTablosu_Click);
            // 
            // btnKategoriTablosu
            // 
            this.btnKategoriTablosu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKategoriTablosu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriTablosu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKategoriTablosu.Location = new System.Drawing.Point(294, 322);
            this.btnKategoriTablosu.Name = "btnKategoriTablosu";
            this.btnKategoriTablosu.Size = new System.Drawing.Size(233, 35);
            this.btnKategoriTablosu.TabIndex = 21;
            this.btnKategoriTablosu.Text = "Kategori Tablosu";
            this.btnKategoriTablosu.UseVisualStyleBackColor = false;
            this.btnKategoriTablosu.Click += new System.EventHandler(this.btnKategoriTablosu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnView.Location = new System.Drawing.Point(1216, 248);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(127, 35);
            this.btnView.TabIndex = 25;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1355, 441);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnSiparisTablosu);
            this.Controls.Add(this.btnKategoriTablosu);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Name = "frmKitap";
            this.Text = "Kitap";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStokAdedi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtKitapArkasi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtFiyatId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxYayinevi;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.Button btnSiparisTablosu;
        private System.Windows.Forms.Button btnKategoriTablosu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFotograf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnView;
    }
}

