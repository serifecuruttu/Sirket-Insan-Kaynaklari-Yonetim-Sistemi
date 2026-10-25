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
    public partial class UcAnaSayfa : UserControl
    {
        public UcAnaSayfa()
        {
            InitializeComponent();
            BilgiKartlariniGuncelle();
            SonIslemleriGetir();

        }

        private int SayiGetir(string sorgu)
        {
            using (SqlConnection baglanti = VeriTabani.BaglantiOlustur())
            {
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    return Convert.ToInt32(komut.ExecuteScalar());
                }
            }
        }



        private void BilgiKartlariniGuncelle()
        {
            lblPersonel.Text =
                SayiGetir("SELECT COUNT(*) FROM Calisanlar").ToString();

            lblİzinTalep.Text =
                SayiGetir(
                    "SELECT COUNT(*) FROM Izinler WHERE Durum = N'Beklemede'"
                ).ToString();

            lblEgitim.Text =
                SayiGetir(
                    "SELECT COUNT(*) FROM Egitimler " +
                    "WHERE EgitimTarihi >= CAST(GETDATE() AS DATE) " +
                    "AND Durum = 1"
                ).ToString();

            lblDepartman.Text =
                SayiGetir("SELECT COUNT(*) FROM Departmanlar").ToString();
        }


        private void SonIslemleriGetir()
        {
            string sorgu = @"
    SELECT TOP 20 *
    FROM
    (
        SELECT
            N'İzin Talebi' AS IslemTuru,
            CONCAT(C.Ad, N' ', C.Soyad) AS Kisi,
            CONCAT(N'İzin türü: ', I.IzinTuru) AS Aciklama,
            I.TalepTarihi AS Tarih,
            I.Durum AS Durum
        FROM Izinler I
        INNER JOIN Calisanlar C
            ON I.CalisanID = C.CalisanID

        UNION ALL

        SELECT
            N'İş Başvurusu',
            CONCAT(B.Ad, N' ', B.Soyad),
            CONCAT(N'E-posta: ', B.Eposta),
            B.BasvuruTarihi,
            B.Durum
        FROM IsBasvurulari B

        UNION ALL

        SELECT
            N'Giriş-Çıkış',
            CONCAT(C.Ad, N' ', C.Soyad),
            CONCAT(N'Günlük durum: ', D.Durum),
            D.Tarih,
            D.Durum
        FROM DevamKayitlari D
        INNER JOIN Calisanlar C
            ON D.CalisanID = C.CalisanID

        UNION ALL

        SELECT
            N'Performans',
            CONCAT(C.Ad, N' ', C.Soyad),
            CONCAT(N'Genel puan: ', P.GenelPuan),
            P.DegerlendirmeTarihi,
            N'Tamamlandı'
        FROM PerformansDegerlendirmeleri P
        INNER JOIN Calisanlar C
            ON P.CalisanID = C.CalisanID
    ) AS SonIslemler
    ORDER BY Tarih DESC;";

            using (SqlConnection baglanti = VeriTabani.BaglantiOlustur())
            {
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(sorgu, baglanti))
                {
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);

                    dgvSonIslemler.DataSource = tablo;

                    dgvSonIslemler.Columns["IslemTuru"].HeaderText = "İşlem Türü";
                    dgvSonIslemler.Columns["Kisi"].HeaderText = "Kişi";
                    dgvSonIslemler.Columns["Aciklama"].HeaderText = "Açıklama";
                    dgvSonIslemler.Columns["Tarih"].HeaderText = "Tarih";
                    dgvSonIslemler.Columns["Durum"].HeaderText = "Durum";
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            BilgiKartlariniGuncelle();
            SonIslemleriGetir();
        }
    }
}
