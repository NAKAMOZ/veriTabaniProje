using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace proje
{
    public partial class anaSayfa : KryptonForm
    {
        public anaSayfa()
        {
            InitializeComponent();
        }
        sqlConnections conn = new sqlConnections();
        int a = 0;
        double sayfaSayi, sayi = 1;
        private void anaSayfa_Load(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT id,ad,(case when cinsiyet = 0 then 'Erkek' when cinsiyet = 1 then 'Kadın' end),yas,boy,kilo,phone,mail,adres,idealKilo,VucutKiEn FROM danisanlar ORDER BY id OFFSET " + a + " ROWS FETCH FIRST 25 ROWS ONLY; ", conn.baglanti());
            DataTable tablo = new DataTable();
            cmd.Fill(tablo);
            danisanlar.DataSource = tablo;
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM danisanlar", conn.baglanti());
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                string sayfa = dr[0].ToString();
                sayfaSayi = Convert.ToDouble(sayfa);
                sayfaSayi = sayfaSayi / 25;
                sayfaSayi = Math.Ceiling(sayfaSayi);
            }
            sayfaNo.Text = "Sayfa " + sayi + "/" + sayfaSayi;
            conn.baglanti().Close();
            geri.Enabled = false;
        }

        private void yenileButon_Click(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT id,ad,(case when cinsiyet = 0 then 'Erkek' when cinsiyet = 1 then 'Kadın' end),yas,boy,kilo,phone,mail,adres,idealKilo,VucutKiEn FROM danisanlar ORDER BY id OFFSET " + a + " ROWS FETCH FIRST 25 ROWS ONLY; ", conn.baglanti());
            DataTable tablo = new DataTable();
            cmd.Fill(tablo);
            danisanlar.DataSource = tablo;
            conn.baglanti().Close();
        }

        private void ekleButon_Click(object sender, EventArgs e)
        {
            ekleDuzenle ekle = new ekleDuzenle();
            ekle.durum = 1;
            ekle.Show();
        }

        private void arama_Enter(object sender, EventArgs e)
        {
            if (arama.Text == "Arayacağınız Kişinin Adını Ve Ya ID'sini Giriniz")
            {
                arama.Text = "";
            }
        }

        private void arama_Leave(object sender, EventArgs e)
        {
            if (arama.Text == "")
            {
                arama.Text = "Arayacağınız Kişinin Adını Ve Ya ID'sini Giriniz";

            }
        }

        private void aramaButon_Click(object sender, EventArgs e)
        {
            string aranan = arama.Text;
            if (aranan != "Arayacağınız Kişinin Adını Giriniz" && aranan != "")
            {
                SqlDataAdapter ara = new SqlDataAdapter("SELECT id,ad,(case when cinsiyet = 0 then 'Erkek' when cinsiyet = 1 then 'Kadın' end),yas,boy,kilo,phone,mail,adres,idealKilo,VucutKiEn FROM danisanlar WHERE ad LIKE '%" + aranan + "%' or id like '" + aranan + "'", conn.baglanti());
                DataTable tablo = new DataTable();
                ara.Fill(tablo);
                danisanlar.DataSource = tablo;
                conn.baglanti().Close();
            }
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            a += 25;
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT id,ad,(case when cinsiyet = 0 then 'Erkek' when cinsiyet = 1 then 'Kadın' end),yas,boy,kilo,phone,mail,adres,idealKilo,VucutKiEn FROM danisanlar ORDER BY id OFFSET " + a + " ROWS FETCH FIRST 25 ROWS ONLY; ", conn.baglanti());
            DataTable tablo = new DataTable();
            cmd.Fill(tablo);
            danisanlar.DataSource = tablo;
            conn.baglanti().Close();
            geri.Enabled = true;
            sayi += 1;
            sayfaNo.Text = "Sayfa " + sayi + "/" + sayfaSayi;
            if (sayfaSayi == sayi)
            {
                ileri.Enabled = false;
            }
        }

        private void danisanlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = danisanlar.SelectedCells[0].RowIndex;
            ekleDuzenle ekle = new ekleDuzenle();
            ekle.idDanisan = danisanlar.Rows[secilen].Cells[0].Value.ToString();
            ekle.adDanisan = danisanlar.Rows[secilen].Cells[1].Value.ToString();
            ekle.cinDanisan = danisanlar.Rows[secilen].Cells[2].Value.ToString();
            ekle.yasDanisan = danisanlar.Rows[secilen].Cells[3].Value.ToString();
            ekle.boyDanisan = danisanlar.Rows[secilen].Cells[4].Value.ToString();
            ekle.kiloDanisan = danisanlar.Rows[secilen].Cells[5].Value.ToString();
            ekle.phoneDanisan = danisanlar.Rows[secilen].Cells[6].Value.ToString();
            ekle.mailDanisan = danisanlar.Rows[secilen].Cells[7].Value.ToString();
            ekle.adresDanisan = danisanlar.Rows[secilen].Cells[8].Value.ToString();
            ekle.idealKiloDanisan = danisanlar.Rows[secilen].Cells[9].Value.ToString();
            ekle.vucutKiEnDanisan = danisanlar.Rows[secilen].Cells[10].Value.ToString();
            ekle.durum = 2;
            ekle.Show();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            a -= 25;
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT id,ad,(case when cinsiyet = 0 then 'Erkek' when cinsiyet = 1 then 'Kadın' end),yas,boy,kilo,phone,mail,adres,idealKilo,VucutKiEn FROM danisanlar ORDER BY id OFFSET " + a + " ROWS FETCH FIRST 25 ROWS ONLY; ", conn.baglanti());
            DataTable tablo = new DataTable();
            cmd.Fill(tablo);
            danisanlar.DataSource = tablo;
            conn.baglanti().Close();
            if (a == 0)
            {
                geri.Enabled = false;
            }
            sayi -= 1;
            sayfaNo.Text = "Sayfa " + sayi + "/" + sayfaSayi;
        }
    }
}
