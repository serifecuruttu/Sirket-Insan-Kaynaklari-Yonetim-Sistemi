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
    public partial class FrmSifreBelirle : Form
    {
        public int KullaniciID { get; private set; }
        public FrmSifreBelirle(int kullaniciID)
        {
            InitializeComponent();
            KullaniciID = kullaniciID;
        }

        private void btnSifreBelirle_Click(object sender, EventArgs e)
        {
            string yeniSifre = txtYeniSifre.Text;
            string sifreTekrar = txtSifreTekrar.Text;

            if (yeniSifre == "" || sifreTekrar == "")
            {
                lblSifreSonuc.Text = "Lütfen iki şifre alanını da doldurun.";
                return;
            }

            if (yeniSifre != sifreTekrar)
            {
                lblSifreSonuc.Text = "Şifreler birbiriyle aynı değil.";
                return;
            }

            if (yeniSifre.Length < 8)
            {
                lblSifreSonuc.Text = "Şifre en az 8 karakter olmalıdır.";
                return;
            }

            string sifreHash = BCrypt.Net.BCrypt.HashPassword(yeniSifre);

            try
            {
                using (SqlConnection baglanti = VeriTabanı.BaglantiOlustur())
                {
                    baglanti.Open();

                    string sorgu = @"
                   UPDATE Kullanicilar
                   SET SifreHash = @SifreHash,
                     IlkGirisMi = 0
                   WHERE KullaniciID = @KullaniciID
                     AND IlkGirisMi = 1
                     AND SifreHash = 'GECICI'";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@SifreHash", sifreHash);
                        komut.Parameters.AddWithValue("@KullaniciID", KullaniciID);

                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc == 1)
                        {
                            lblSifreSonuc.Text = "Şifreniz başarıyla belirlendi!";
                            txtYeniSifre.Clear();
                            txtSifreTekrar.Clear();
                        }
                        else
                        {
                            lblSifreSonuc.Text =
                                "Admin hesabı bulunamadı veya daha önce ayarlanmış.";
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu: " + hata.Message);
            }
        }
    }
}
