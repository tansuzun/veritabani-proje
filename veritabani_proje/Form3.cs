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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432;Database=dbBookStore;user ID=postgres;password=123456T");

        private void btnListele_Click(object sender, EventArgs e)
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Siparis\"", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand(@"insert into ""Siparis""
            (""kargoId"",""satisTemsilcisiId"",""faturaId"",""musteriId"",""siparisTarihi"",""toplamTutar"")
            values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
         

            komut1.Parameters.AddWithValue("@p1", cbxKargo.SelectedValue);
            komut1.Parameters.AddWithValue("@p2", cbxSatisTemsilcisi.SelectedValue);
            komut1.Parameters.AddWithValue("@p3", int.Parse(txtFaturaId.Text));
            komut1.Parameters.AddWithValue("@p4", cbxMusteri.SelectedValue);
            komut1.Parameters.AddWithValue("@p5", DateTime.Parse(txtSiparisTarihi.Text));
            komut1.Parameters.AddWithValue("@p6", int.Parse(txtToplam.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme başarılı!");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand(@"delete from ""Siparis"" where ""siparisId""=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtSiparisId.Text));
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

        private void btnKitapTablosu_Click(object sender, EventArgs e)
        {
            frmKitap formKitap = new frmKitap();
            formKitap.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand(@"update ""Siparis"" set ""kargoId""=@p1,""satisTemsilcisiId""=@p2,""faturaId""=@p3,""musteriId""=@p4,""siparisTarihi""=@p5 where ""siparisId""=@p6", baglanti);
            komut2.Parameters.AddWithValue("@p1", cbxKargo.SelectedValue);
            komut2.Parameters.AddWithValue("@p2", cbxSatisTemsilcisi.SelectedValue);
            komut2.Parameters.AddWithValue("@p3", int.Parse(txtFaturaId.Text));
            komut2.Parameters.AddWithValue("@p4", cbxMusteri.SelectedValue);
            komut2.Parameters.AddWithValue("@p5", DateTime.Parse(txtSiparisTarihi.Text));
            komut2.Parameters.AddWithValue("@p6", int.Parse(txtSiparisId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme başarılı!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //Seçilen satırdaki değerleri textbox'lara yazdırıyor.
            txtSiparisId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cbxKargo.SelectedValue= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cbxSatisTemsilcisi.SelectedValue= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtFaturaId.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cbxMusteri.SelectedValue= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSiparisTarihi.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Siparis\" where \"musteriId\"=" + int.Parse(txtArama.Text), baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Kargo\"", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxKargo.DisplayMember = "kargoFirmasi";
            cbxKargo.ValueMember = "kargoId";
            cbxKargo.DataSource = dt;

            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from \"SatisTemsilcisi\"", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbxSatisTemsilcisi.DisplayMember = "isim";
            cbxSatisTemsilcisi.ValueMember = "kisiId";
            cbxSatisTemsilcisi.DataSource = dt1;


            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from \"Musteri\"", baglanti);
            DataTable dt2= new DataTable();
            da2.Fill(dt2);
            cbxMusteri.DisplayMember = "isim";
            cbxMusteri.ValueMember = "kisiId";
            cbxMusteri.DataSource = dt2;
            baglanti.Close();

            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("select * from \"Kitap\"", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cbxKitap.DisplayMember = "kitapAdi";
            cbxKitap.ValueMember = "kitapId";
            cbxKitap.DataSource = dt3;
            baglanti.Close();

        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand(@"insert into ""SiparisKitap""
            (""siparisId"",""kitapId"",""miktar"",""fiyatId"")
            values (@p1,@p2,@p3,@p4)", baglanti);           

            komut3.Parameters.AddWithValue("@p1", int.Parse(txtSiparisIdKitap.Text));
            komut3.Parameters.AddWithValue("@p2", cbxKitap.SelectedValue);
            komut3.Parameters.AddWithValue("@p3", int.Parse(txtMiktar.Text));
            komut3.Parameters.AddWithValue("@p4", int.Parse(txtFiyatId.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme başarılı!");
        }

        private void cbxKitap_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
