using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    public class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan =new SqlConnection("Data Source=DESKTOP-FKLG4QN;Initial Catalog=HastaneDb;Integrated Security=True;Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=true;");

            baglan.Open();
            return baglan;
        }

    }
}
