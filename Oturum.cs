using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insanKaynaklariYonetimSistemi
{
    public static class Oturum
    {
        public static int KullaniciID { get; set; }
        public static string KullaniciAdi { get; set; }
        public static string Rol { get; set; }

        public static void OturumuKapat()
        {
            KullaniciID = 0;
            KullaniciAdi = "";
            Rol = "";
        }
    }
}
