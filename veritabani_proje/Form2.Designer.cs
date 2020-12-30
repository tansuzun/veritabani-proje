namespace veritabani_proje
{
    partial class frmKategori
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSiparisTablosu = new System.Windows.Forms.Button();
            this.btnKitapTablosu = new System.Windows.Forms.Button();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(453, 19);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(42, 23);
            this.btnAra.TabIndex = 27;
            this.btnAra.Text = "🔍";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(772, 159);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(179, 29);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(772, 124);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(179, 29);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.White;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(772, 89);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(179, 29);
            this.btnListele.TabIndex = 23;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(591, 163);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(147, 20);
            this.txtKategori.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(519, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(772, 196);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(179, 29);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 234);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSiparisTablosu
            // 
            this.btnSiparisTablosu.BackColor = System.Drawing.Color.White;
            this.btnSiparisTablosu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisTablosu.Location = new System.Drawing.Point(277, 288);
            this.btnSiparisTablosu.Name = "btnSiparisTablosu";
            this.btnSiparisTablosu.Size = new System.Drawing.Size(192, 29);
            this.btnSiparisTablosu.TabIndex = 29;
            this.btnSiparisTablosu.Text = "Siparis Tablosu";
            this.btnSiparisTablosu.UseVisualStyleBackColor = false;
            this.btnSiparisTablosu.Click += new System.EventHandler(this.btnSiparisTablosu_Click);
            // 
            // btnKitapTablosu
            // 
            this.btnKitapTablosu.BackColor = System.Drawing.Color.White;
            this.btnKitapTablosu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapTablosu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKitapTablosu.Location = new System.Drawing.Point(66, 288);
            this.btnKitapTablosu.Name = "btnKitapTablosu";
            this.btnKitapTablosu.Size = new System.Drawing.Size(192, 29);
            this.btnKitapTablosu.TabIndex = 28;
            this.btnKitapTablosu.Text = "Kitap Tablosu";
            this.btnKitapTablosu.UseVisualStyleBackColor = false;
            this.btnKitapTablosu.Click += new System.EventHandler(this.btnKitapTablosu_Click);
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(591, 133);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(147, 20);
            this.txtKategoriId.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(501, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kategori Id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(181, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "Ada göre arama:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(300, 22);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(147, 20);
            this.txtArama.TabIndex = 33;
            // 
            // frmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(997, 353);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtKategoriId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiparisTablosu);
            this.Controls.Add(this.btnKitapTablosu);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.label2);
            this.Name = "frmKategori";
            this.Text = "Kategori";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSiparisTablosu;
        private System.Windows.Forms.Button btnKitapTablosu;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArama;
    }
}