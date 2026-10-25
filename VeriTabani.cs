using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insanKaynaklariYonetimSistemi
{
    public static class VeriTabani
    {
        public static SqlConnection BaglantiOlustur()
        {
            string baglantiAdresi = @"Data Source=localHost;Initial Catalog=insanKaynaklariYsDB;Integrated Security=True;TrustServerCertificate=True";

            return new SqlConnection(baglantiAdresi);

        }
    }
}
