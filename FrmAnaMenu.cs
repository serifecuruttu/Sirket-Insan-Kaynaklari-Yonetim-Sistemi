using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace insanKaynaklariYonetimSistemi
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            IcerikGoster(new UcAnaSayfa());
            lblKullaniciBilgisi.Text =  "Hoş geldiniz, " + Oturum.KullaniciAdi  + " (" + Oturum.Rol + ")";

            bool admin = Oturum.Rol == "Admin";
            bool ikPersoneli = Oturum.Rol == "IKPersoneli";
            bool calisan = Oturum.Rol == "Calisan";

            btnKullanici.Visible = admin;
            btnCalisan.Visible = admin || ikPersoneli;
            btnDepartman.Visible = admin || ikPersoneli;
            btnRaporlar.Visible = admin || ikPersoneli;

            btnİzin.Visible = admin || ikPersoneli || calisan;
            btnPerformans.Visible = admin || ikPersoneli || calisan;
            btnEgitim.Visible = admin || ikPersoneli || calisan;

            btnCikis.Visible = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Oturum.OturumuKapat();

            FrmGiris giris = Application.OpenForms["FrmGiris"] as FrmGiris;

            if (giris != null)
            {
                giris.Show();
                giris.Activate();
            }

            this.Hide();
        }

        private void IcerikGoster(UserControl kontrol)
        {
            pnlIcerik.Controls.Clear();

            kontrol.Dock = DockStyle.Fill;

            pnlIcerik.Controls.Add(kontrol);
            kontrol.BringToFront();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            IcerikGoster(new UcAnaSayfa());
        }

        private void btnCalisan_Click(object sender, EventArgs e)
        {
            IcerikGoster(new UcCalisanlar());
        }
    }
}
