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
   public class ders
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANMDKME\\SQLEXPRESS;Initial Catalog=obs1;Integrated Security=True");
        public int DEkle(VAR.ders ders)
        {
            SqlCommand cmd = new SqlCommand("dersekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dersadi", ders.Dersadi);
            cmd.Parameters.AddWithValue("@bolum", ders.Bolum);
            cmd.Parameters.AddWithValue("@hocasi", ders.Hocasi);
            cmd.Parameters.AddWithValue("@donem", ders.Donem);

            con.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return id;
        }
        public int DGuncelle(VAR.ders ders)
        {
            SqlCommand cmd = new SqlCommand("dersduzenle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dersadi", ders.Dersadi);
            cmd.Parameters.AddWithValue("@bolum", ders.Bolum);
            cmd.Parameters.AddWithValue("@hocasi", ders.Hocasi);
            cmd.Parameters.AddWithValue("@donem", ders.Donem);

            con.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return id;
        }
        public DataTable dersliste()
        {
            SqlDataAdapter da = new SqlDataAdapter("derslistele", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void dersSil(VAR.ders Sders)
        {
            SqlCommand cmd = new SqlCommand("derssil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dersno", Sders.Dersno);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
