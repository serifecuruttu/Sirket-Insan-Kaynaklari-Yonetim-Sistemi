using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insanKaynaklariYonetimSistemi
{
    public partial class FrmGiris : Form
    {

        SqlConnection baglanti = new SqlConnection(
        "Server=.;Database= insanKaynaklariDB;Trusted_Connection=True;");
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                "SELECT * FROM KuLLanicilar WHERE KullaniciAdi =@KullaniciAdi AND Sifre=@Sifre", baglanti);
            komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            { 
                MessageBox.Show("Giriş Başarılı!");
                FrmAnaMenu frm = new FrmAnaMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
                txtSifre.Clear();
                txtSifre.Focus();
            }
            
            baglanti.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
