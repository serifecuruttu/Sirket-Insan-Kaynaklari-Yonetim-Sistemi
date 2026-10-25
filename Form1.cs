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

        SqlConnection baglanti = VeriTabani.BaglantiOlustur();

        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = VeriTabanı.BaglantiOlustur())
            {
                baglanti.Open();

                string sorgu = @"
            SELECT KullaniciID, SifreHash, Rol, Durum, IlkGirisMi
            FROM Kullanicilar
            WHERE KullaniciAdi = @KullaniciAdi";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue(
                        "@KullaniciAdi", txtKullaniciAdi.Text.Trim());

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                            return;
                        }

                        int kullaniciID = Convert.ToInt32(dr["KullaniciID"]);
                        string sifreHash = dr["SifreHash"].ToString();
                        string rol = dr["Rol"].ToString();
                        bool aktif = Convert.ToBoolean(dr["Durum"]);
                        bool ilkGiris = Convert.ToBoolean(dr["IlkGirisMi"]);

                        if (!aktif)
                        {
                            MessageBox.Show("Hesabınız aktif değil.");
                            return;
                        }

                        if (ilkGiris && sifreHash == "GECICI")
                        {
                            dr.Close();

                            FrmSifreBelirle frm =
                                new FrmSifreBelirle(kullaniciID);

                            frm.ShowDialog();
                            return;
                        }

                        if (ilkGiris)
                        {
                            MessageBox.Show("Önce şifrenizi belirlemelisiniz.");
                            return;
                        }

                        string girilenSifre = txtSifre.Text;

                        if (!BCrypt.Net.BCrypt.Verify(girilenSifre, sifreHash))
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                            return;
                        }

                        Oturum.KullaniciID = kullaniciID;
                        Oturum.KullaniciAdi = txtKullaniciAdi.Text.Trim();
                        Oturum.Rol = rol;
                    }
                }
            }

            MessageBox.Show("Giriş başarılı!");

            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
