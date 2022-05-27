using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VAR = Varlıklar;

namespace VeriErisimKatmanı
{
   public class ogrders
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANMDKME\\SQLEXPRESS;Initial Catalog=obs1;Integrated Security=True");
        public int ogrdersEkle(VAR.ogrders ogrenci)
        {
            SqlCommand cmd = new SqlCommand("dersata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ogrid", ogrenci.Ogrid);
            cmd.Parameters.AddWithValue("@dersno", ogrenci.Dersno);
            //cmd.Parameters.AddWithValue("@vize", ogrenci.Vize);
            //cmd.Parameters.AddWithValue("@final", ogrenci.Final);
            //cmd.Parameters.AddWithValue("@ortalama", ogrenci.Ortalama);
            //cmd.Parameters.AddWithValue("@harfnotu", ogrenci.Harfnotu);

            con.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return id;
        }
        public int ogrdersGuncelle(VAR.ogrders ogrenci)
        {
            SqlCommand cmd = new SqlCommand("notgir", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ogrid", ogrenci.Ogrid);
            cmd.Parameters.AddWithValue("@dersno", ogrenci.Dersno);
            cmd.Parameters.AddWithValue("@vize", ogrenci.Vize);
            cmd.Parameters.AddWithValue("@final", ogrenci.Final);
            cmd.Parameters.AddWithValue("@ortalama", ogrenci.Ortalama);
            cmd.Parameters.AddWithValue("@harfnotu", ogrenci.Harfnotu);

            con.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return id;
        }
        public DataTable ogrdersliste()
        {
            SqlDataAdapter da = new SqlDataAdapter("ogrderslistele", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
