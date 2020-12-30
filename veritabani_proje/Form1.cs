using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabani_proje
{
    public partial class frmKitap : Form
    {
        public frmKitap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432;Database=dbBookStore;user ID=postgres;password=123456T");

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Kategori\"", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxKategori.DisplayMember = "kategoriAdi";
            cbxKategori.ValueMember = "kategoriId";
            cbxKategori.DataSource = dt;

            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from \"Yayinevi\"", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbxYayinevi.DisplayMember = "yayineviAdi";
            cbxYayinevi.ValueMember = "yayineviId";
            cbxYayinevi.DataSource = dt1;
            baglanti.Close();

        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            txtArama.Clear();
            txtFiyatId.Clear();
            txtFotograf.Clear();
            txtKitapAdi.Clear();
            txtKitapId.Clear();
            txtSayfaSayisi.Clear();
            txtStokAdedi.Clear();
            txtYazar.Clear();
            rtxtKitapArkasi.Clear();

            string sorgu="select * from \"Kitap\" order by \"kitapId\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand(@"insert into ""Kitap""
            (""kitapAdi"",""kategoriId"",""yayineviId"",""yazar"",""sayfaSayisi"",""stokAdedi"",""fiyatId"",""fotograf"",""kitapArkasi"")
            values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            NpgsqlCommand kmt = new NpgsqlCommand(@"insert into ""Fotograf"" (""fotograf"",""kitap"") values (@p10,@p11)",baglanti);
            kmt.Parameters.AddWithValue("@p10", txtFotograf.Text);
            kmt.Parameters.AddWithValue("@p11", txtKitapAdi.Text);

            komut1.Parameters.AddWithValue("@p1", txtKitapAdi.Text);
            komut1.Parameters.AddWithValue("@p2", cbxKategori.SelectedValue);
            komut1.Parameters.AddWithValue("@p3", cbxYayinevi.SelectedValue);
            komut1.Parameters.AddWithValue("@p4", txtYazar.Text);
            komut1.Parameters.AddWithValue("@p5", int.Parse(txtSayfaSayisi.Text));
            komut1.Parameters.AddWithValue("@p6", int.Parse(txtStokAdedi.Text));
            komut1.Parameters.AddWithValue("@p7", int.Parse(txtFiyatId.Text));
            komut1.Parameters.AddWithValue("@p8", txtFotograf.Text);
            komut1.Parameters.AddWithValue("@p9", rtxtKitapArkasi.Text);

            kmt.ExecuteNonQuery();
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme başarılı!");
        
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand(@"delete from ""Kitap"" where ""kitapId""=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtKitapId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme başarılı!");
        }

        private void btnKategoriTablosu_Click(object sender, EventArgs e)
        {
            frmKategori formKategori = new frmKategori();
            formKategori.Show();
            this.Hide();
        }

        private void btnYayineviTablosu_Click(object sender, EventArgs e)
        {
            frmSiparis formSiparis = new frmSiparis();
            formSiparis.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand(@"update ""Kitap"" set ""kitapAdi""=@p1,""kategoriId""=@p2,""yayineviId""=@p3,""yazar""=@p4,""sayfaSayisi""=@p5,""stokAdedi""=@p6,""fiyatId""=@p7,""fotograf""=@p8,""kitapArkasi""=@p9 where ""kitapId""=@p10", baglanti);

          
            komut3.Parameters.AddWithValue("@p1", txtKitapAdi.Text);
            komut3.Parameters.AddWithValue("@p2", cbxKategori.SelectedValue);
            komut3.Parameters.AddWithValue("@p3", cbxYayinevi.SelectedValue);
            komut3.Parameters.AddWithValue("@p4", txtYazar.Text);
            komut3.Parameters.AddWithValue("@p5", int.Parse(txtSayfaSayisi.Text));
            komut3.Parameters.AddWithValue("@p6", int.Parse(txtStokAdedi.Text));
            komut3.Parameters.AddWithValue("@p7", int.Parse(txtFiyatId.Text));
            komut3.Parameters.AddWithValue("@p8", txtFotograf.Text);
            komut3.Parameters.AddWithValue("@p9", rtxtKitapArkasi.Text);
            komut3.Parameters.AddWithValue("@p10", int.Parse(txtKitapId.Text));


            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Güncelleme başarılı!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

            //Seçilen satırdaki değerleri textbox'lara yazdırıyor.
            txtKitapId.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cbxYayinevi.SelectedValue = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cbxKategori.SelectedValue = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtKitapAdi.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYazar.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSayfaSayisi.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtStokAdedi.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            rtxtKitapArkasi.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtFiyatId.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtFotograf.Text= dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Kitap\" where \"kitapAdi\" like '%" + txtArama.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }




        private void btnView_Click(object sender, EventArgs e)
        {

            NpgsqlCommand komut5 = new NpgsqlCommand(@"select * from ""kitap_ozellikler"" order by ""kitapId""", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
