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
    public partial class giris : KryptonForm
    {
        public giris()
        {
            InitializeComponent();
        }
        sqlConnections conn = new sqlConnections();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mail_Enter(object sender, EventArgs e)
        {
            if (mail.Text == "Mail Adresinizi Giriniz")
            {
                mail.Text = "";
            }
        }

        private void mail_Leave(object sender, EventArgs e)
        {
            if (mail.Text == "")
            {
                mail.Text = "Mail Adresinizi Giriniz";

            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Şifrenizi Giriniz")
            {
                password.Text = "";
            }
            password.UseSystemPasswordChar = true;
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Şifrenizi Giriniz";

                password.UseSystemPasswordChar = false;
            }

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from diyetisyen where mail=@p1 and sifre=@p2", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", mail.Text);
            cmd.Parameters.AddWithValue("@p2", password.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                anaSayfa frm = new anaSayfa();
                frm.Show();
                this.Hide();
            }
            else if (mail.Text == "Mail Adresinizi Giriniz" && password.Text == "Şifrenizi Giriniz")
            {
                label3.Visible = true;
                label3.Text = "Lütfen Gerekli Yerleri Doldurunuz!";
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Girmiş Olduğunuz Bilgiler Hatalı\nLütfen Tekrar Deneyiniz";
            }
            conn.baglanti().Close();
        }
    }
}
