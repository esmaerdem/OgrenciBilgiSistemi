using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VeriErisimKatmanı
{
  public  class baglanti
    {
        static string con = "Data Source=DESKTOP-ANMDKME\\SQLEXPRESS;Initial Catalog=obs1;Integrated Security=True";
        public static SqlConnection BaglantiGetir() {
            SqlConnection baglanti = new SqlConnection(con);
            return baglanti;
        }
        public static void BaglantiSonlandir(SqlConnection baglanti)
        {
            if (baglanti == null)
            {
                return;
            }
            if (baglanti.State != ConnectionState.Closed && baglanti.State != ConnectionState.Broken)
            {
                baglanti.Close();
            }
            baglanti.Dispose();
        }
    }
}
