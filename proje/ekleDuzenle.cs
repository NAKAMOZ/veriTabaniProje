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
    public partial class ekleDuzenle : KryptonForm
    {
        public ekleDuzenle()
        {
            InitializeComponent();
        }
        sqlConnections conn = new sqlConnections();
        public int durum;
        public string idDanisan, adDanisan, cinDanisan, yasDanisan, boyDanisan, kiloDanisan, phoneDanisan, mailDanisan, adresDanisan, idealKiloDanisan, vucutKiEnDanisan;

        private void ekleDuzenle_Load(object sender, EventArgs e)
        {
            if (durum == 1)
            {
                duzenle.Visible = false;
                sil.Visible = false;
                ekle.Visible = true;
                temizle.Visible = true;
            }
            else if (durum == 2)
            {
                duzenle.Visible = true;
                ekle.Visible = false;
                txtAd.Text = adDanisan;
                if (cinDanisan == "Erkek")
                {
                    cinsiyet0.Checked = true;
                }
                else if (cinDanisan == "Kadin")
                {
                    cinsiyet1.Checked = true;
                }
                txtBoy.Text = boyDanisan;
                txtKilo.Text = kiloDanisan;
                txtYas.Text = yasDanisan;
                txtPhone.Text = phoneDanisan;
                txtMail.Text = mailDanisan;
                txtSehir.Text = adresDanisan;
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtAd.Text == "Danışanın Adını Giriniz" || txtBoy.Text == "" || txtBoy.Text == "Danışanın Boyunu Giriniz" || txtKilo.Text == " " || txtKilo.Text == "Danışanın Kilosunu Giriniz" || txtYas.Text == "" || txtYas.Text == "Danışanın Yaşını Giriniz" || txtPhone.Text == "" || txtPhone.Text == "(___) ___-____" || txtMail.Text == "" || txtMail.Text == "Danışanın Mail Adresini Giriniz" || txtSehir.Text == "" || txtSehir.Text == "Danışanın Şehrini Giriniz" || (cinsiyet0.Checked == false && cinsiyet1.Checked == false))
            {
                hata.ForeColor = Color.FromArgb(1, 205, 24, 24);
                hata.Visible = true;
                hata.Text = "Lütfen Boş Yer Bırakmayınız";
            }
            else
            {
                int cin = 2;
                SqlCommand cmd = new SqlCommand("INSERT INTO [danisanlar] (ad,cinsiyet,boy,kilo,yas,phone,mail,adres,idealKilo,vucutKiEn) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", conn.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                if (cinsiyet0.Checked == true)
                {
                    cin = 0;
                    cmd.Parameters.AddWithValue("@p2", cin);
                }
                else if (cinsiyet1.Checked == true)
                {
                    cin = 1;
                    cmd.Parameters.AddWithValue("@p2", cin);
                }
                cmd.Parameters.AddWithValue("@p3", txtBoy.Text);
                cmd.Parameters.AddWithValue("@p4", txtKilo.Text);
                cmd.Parameters.AddWithValue("@p5", txtYas.Text);
                cmd.Parameters.AddWithValue("@p6", txtPhone.Text);
                cmd.Parameters.AddWithValue("@p7", txtMail.Text);
                cmd.Parameters.AddWithValue("@p8", txtSehir.Text);
                double k = Convert.ToInt32(txtKilo.Text), b = Convert.ToInt32(txtBoy.Text);
                double x, z;
                if (cin == 0)
                {
                    z = 50 + 2.3 * ((0.393700787 * b) - 60);
                    cmd.Parameters.AddWithValue("@p9", Math.Round(z, 1));
                }
                else if (cin == 1)
                {
                    z = 45.5 + 2.3 * ((0.393700787 * b) - 60);
                    cmd.Parameters.AddWithValue("@p9", Math.Round(z, 1));
                }
                double mb = b / 100;
                x = k / (mb * mb);
                cmd.Parameters.AddWithValue("@p10", Math.Round(x, 1));
                hata.Text = "Kayıt İşlemi Başarılı";
                hata.ForeColor = Color.FromArgb(1, 0, 192, 0);
                hata.Visible = true;
                cmd.ExecuteNonQuery();
                conn.baglanti().Close();
                txtAd.Text = "Danışanın Adını Giriniz";
                txtBoy.Text = "Danışanın Boyunu Giriniz";
                txtKilo.Text = "Danışanın Kilosunu Giriniz";
                cinsiyet0.Checked = false;
                cinsiyet1.Checked = false;
                txtMail.Text = "Danışanın Mail Adresini Giriniz";
                txtPhone.Text = "Danışanın Telefon Numarasını Giriniz";
                txtSehir.Text = "Danışanın Şehrini Giriniz";
                txtYas.Text = "Danışanın Yaşını Giriniz";
            }
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "Danışanın Adını Giriniz";
            txtBoy.Text = "Danışanın Boyunu Giriniz";
            txtKilo.Text = "Danışanın Kilosunu Giriniz";
            cinsiyet0.Checked = false;
            cinsiyet1.Checked = false;
            txtMail.Text = "Danışanın Mail Adresini Giriniz";
            txtPhone.Text = "";
            txtSehir.Text = "Danışanın Şehrini Giriniz";
            txtYas.Text = "Danışanın Yaşını Giriniz";
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            int cin = 2;
            SqlCommand cmd = new SqlCommand("UPDATE danisanlar SET ad=@p1,cinsiyet=@p2,boy=@p3,kilo=@p4,yas=@p5,phone=@p6,mail=@p7,adres=@p8,idealKilo=@p9,vucutKiEn=@p10 where id='" + idDanisan + "'", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            if (cinsiyet0.Checked == true)
            {
                cin = 0;
                cmd.Parameters.AddWithValue("@p2", cin);
            }
            else if (cinsiyet1.Checked == true)
            {
                cin = 1;
                cmd.Parameters.AddWithValue("@p2", cin);
            }
            cmd.Parameters.AddWithValue("@p3", txtBoy.Text);
            cmd.Parameters.AddWithValue("@p4", txtKilo.Text);
            cmd.Parameters.AddWithValue("@p5", txtYas.Text);
            cmd.Parameters.AddWithValue("@p6", txtPhone.Text);
            cmd.Parameters.AddWithValue("@p7", txtMail.Text);
            cmd.Parameters.AddWithValue("@p8", txtSehir.Text);
            double k = Convert.ToInt32(txtKilo.Text), b = Convert.ToInt32(txtBoy.Text);
            double x, z;
            if (cin == 0)
            {
                z = 50 + 2.3 * ((0.393700787 * b) - 60);
                cmd.Parameters.AddWithValue("@p9", Math.Round(z, 1));
            }
            else if (cin == 1)
            {
                z = 45.5 + 2.3 * ((0.393700787 * b) - 60);
                cmd.Parameters.AddWithValue("@p9", Math.Round(z, 1));
            }
            double mb = b / 100;
            x = k / (mb * mb);
            cmd.Parameters.AddWithValue("@p10", Math.Round(x, 1));
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            hata.Text = "Güncelleme İşlemi Gerçekleşmiştir";
            hata.ForeColor = Color.FromArgb(1, 0, 192, 0);
            hata.Visible = true;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM danisanlar WHERE id = @p1", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", idDanisan);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            hata.ForeColor = Color.FromArgb(1, 0, 192, 0);
            hata.Text = "Silme İşlemi Başarıyla Gerçekleştirildi";
            hata.Visible = true;
            txtAd.Text = "Danışanın Adını Giriniz";
            txtBoy.Text = "Danışanın Boyunu Giriniz";
            txtKilo.Text = "Danışanın Kilosunu Giriniz";
            cinsiyet0.Checked = false;
            cinsiyet1.Checked = false;
            txtMail.Text = "Danışanın Mail Adresini Giriniz";
            txtPhone.Text = "";
            txtSehir.Text = "Danışanın Şehrini Giriniz";
            txtYas.Text = "Danışanın Yaşını Giriniz";
        }

        private void txtAd_Enter(object sender, EventArgs e)
        {
            if (txtAd.Text == "Danışanın Adını Giriniz")
            {
                txtAd.Text = "";
            }
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                txtAd.Text = "Danışanın Adını Giriniz";
            }
        }

        private void txtBoy_Enter(object sender, EventArgs e)
        {
            if (txtBoy.Text == "Danışanın Boyunu Giriniz")
            {
                txtBoy.Text = "";
            }
        }

        private void txtBoy_Leave(object sender, EventArgs e)
        {
            if (txtBoy.Text == "")
            {
                txtBoy.Text = "Danışanın Boyunu Giriniz";
            }
        }

        private void txtKilo_Enter(object sender, EventArgs e)
        {
            if (txtKilo.Text == "Danışanın Kilosunu Giriniz")
            {
                txtKilo.Text = "";
            }
        }

        private void txtKilo_Leave(object sender, EventArgs e)
        {
            if (txtKilo.Text == "")
            {
                txtKilo.Text = "Danışanın Kilosunu Giriniz";
            }
        }

        private void txtYas_Enter(object sender, EventArgs e)
        {
            if (txtYas.Text == "Danışanın Yaşını Giriniz")
            {
                txtYas.Text = "";
            }
        }

        private void txtYas_Leave(object sender, EventArgs e)
        {
            if (txtYas.Text == "")
            {
                txtYas.Text = "Danışanın Yaşını Giriniz";
            }
        }
        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Danışanın Telefon Numarasını Giriniz")
            {
                txtPhone.Text = "";
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Danışanın Telefon Numarasını Giriniz";
            }
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Danışanın Mail Adresini Giriniz")
            {
                txtMail.Text = "";
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Danışanın Mail Adresini Giriniz";
            }
        }

        private void txtSehir_Enter(object sender, EventArgs e)
        {
            if (txtSehir.Text == "Danışanın Şehrini Giriniz")
            {
                txtSehir.Text = "";
            }
        }

        private void txtSehir_Leave(object sender, EventArgs e)
        {
            if (txtSehir.Text == "")
            {
                txtSehir.Text = "Danışanın Şehrini Giriniz";
            }
        }

    }
}
