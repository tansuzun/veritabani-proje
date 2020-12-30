using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabani_proje
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432;Database=dbBookStore;user ID=postgres;password=123456T");

        private void btnListele_Click(object sender, EventArgs e)
        {

            string sorgu = "select * from \"Kategori\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into \"Kategori\" (\"kategoriAdi\") values (@p1)",baglanti);
            komut1.Parameters.AddWithValue("@p1", txtKategori.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme başarılı!");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand(@"delete from ""Kategori"" where ""kategoriId""=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtKategoriId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme başarılı!");
        }

        private void btnKitapTablosu_Click(object sender, EventArgs e)
        {
            frmKitap formKitap = new frmKitap();
            formKitap.Show();
            this.Hide();
        }

        private void btnSiparisTablosu_Click(object sender, EventArgs e)
        {
            frmSiparis formSiparis = new frmSiparis();
            formSiparis.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand(@"update ""Kategori"" set ""kategoriAdi""=@p1 where ""kategoriId""=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtKategori.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtKategoriId.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme başarılı!");

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Kategori\" where \"kategoriAdi\" like '%" + txtArama.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            //Seçilen satırdaki değerleri textbox'lara yazdırıyor.
            txtKategoriId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKategori.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
