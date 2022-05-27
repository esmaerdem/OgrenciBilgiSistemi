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
  public  class ogrenci
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-ANMDKME\\SQLEXPRESS;Initial Catalog=obs1;Integrated Security=True");
        public static int KullaniciGirisiDogrula(string ogrno, string tcno)
        {
            string spAdi = "ogrgiris";
            komut k = new komut(spAdi);
            k.ParametreEkle("@ogrno", ogrno);
            k.ParametreEkle("@tcno", tcno);  

            int sonuc = k.IsletInt32();
            k.Temizle();

            return sonuc;

        }
       
        //public static DataTable veri(string ogrno)
        //{
        //    string spAdi = "ogrders";
        //    komut k = new komut(spAdi);
        //    k.ParametreEkle("@ogrno", ogrno);
        //    SqlDataAdapter da = new SqlDataAdapter(spAdi, baglanti.BaglantiGetir());
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //    //return sonuc2;
        //}
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANMDKME\\SQLEXPRESS;Initial Catalog=obs1;Integrated Security=True");
        public int Ekle(VAR.ogrenci ogrenci)
        {
            SqlCommand cmd = new SqlCommand("ogrekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ogrno", ogrenci.Ogrno);
            cmd.Parameters.AddWithValue("@tcno", ogrenci.Tcno);
            cmd.Parameters.AddWithValue("@ogrAdSoyad", ogrenci.OgrAdSoyad);
            cmd.Parameters.AddWithValue("@ogrBolum",ogrenci.OgrBolum);
            cmd.Parameters.AddWithValue("@sinif",ogrenci.Sinif);
            cmd.Parameters.AddWithValue("@ceptel",ogrenci.Ceptel);
            cmd.Parameters.AddWithValue("@mail",ogrenci.Mail);

            con.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return id;
        }
        public int Guncelle(VAR.ogrenci ogrenci)
        {
            SqlCommand cmd = new SqlCommand("ogrduzenle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ogrno", ogrenci.Ogrno);
            cmd.Parameters.AddWithValue("@tcno", ogrenci.Tcno);
            cmd.Parameters.AddWithValue("@ogrAdSoyad", ogrenci.OgrAdSoyad);
            cmd.Parameters.AddWithValue("@ogrBolum", ogrenci.OgrBolum);
            cmd.Parameters.AddWithValue("@sinif", ogrenci.Sinif);
            cmd.Parameters.AddWithValue("@ceptel", ogrenci.Ceptel);
            cmd.Parameters.AddWithValue("@mail", ogrenci.Mail);

            con.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return id;
        }

        public DataTable ogrliste()
        {
            SqlDataAdapter da = new SqlDataAdapter("ogrlistele", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ogrSil (VAR.ogrenci Sogrenci)
        {
            SqlCommand cmd = new SqlCommand("ogrsil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ogrid", Sogrenci.Ogrid);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
        //public static bool ogrKaydet(Varlıklar.ogrenci ogremci)
        //{
        //    string spAdi = "ogrekle";
        //    int etkilenen = 0;

        //    komut k = new komut(spAdi);
        //    k.ParametreEkle("@ogrno", ogremci.Ogrno);
        //    k.ParametreEkle("@tcno", ogremci.Tcno);
        //    k.ParametreEkle("@ogrAdSoyad", ogremci.OgrAdSoyad);
        //    k.ParametreEkle("@ogrBolum", ogremci.OgrBolum);
        //    k.ParametreEkle("@sinif", ogremci.Sinif);
        //    k.ParametreEkle("@ceptel", ogremci.Ceptel);
        //    k.ParametreEkle("mail", ogremci.Mail);
        //    k.ParametreEkleOut("@ogrid", SqlDbType.Int, 0);

        //    etkilenen = k.Islet();
        //    if (etkilenen > 0)
        //    {
        //        ogremci.Ogrid = k.OutParametreDegeriGetir("@ogrid");
        //    }
        //    k.Temizle();
        //    return etkilenen > 0;
        //}
        //public static bool ogrGuncelle(Varlıklar.ogrenci ogremci)
        //{
        //    string spAdi = "ogrduzenle";
        //    int etkilenen = 0;

        //    komut k = new komut(spAdi);
        //    k.ParametreEkle("@ogrno", ogremci.Ogrno);
        //    k.ParametreEkle("@tcno", ogremci.Tcno);
        //    k.ParametreEkle("@ogrAdSoyad", ogremci.OgrAdSoyad);
        //    k.ParametreEkle("@ogrBolum", ogremci.OgrBolum);
        //    k.ParametreEkle("@sinif", ogremci.Sinif);
        //    k.ParametreEkle("@ceptel", ogremci.Ceptel);
        //    k.ParametreEkle("mail", ogremci.Mail);

        //    etkilenen = k.Islet();
        //    k.Temizle();
        //    return etkilenen > 0;
        //}
        //public static Varlıklar.ogrders ogrencigetir(int ogrenciNo)
        //{
        //    string spAdi = "ogrderslistele";
        //    Varlıklar.ogrders ogrenci = null;

        //    komut k = new komut(spAdi);
        //    k.ParametreEkle("@ogrid", ogrenciNo);
        //    SqlDataReader sdr = k.IsletReader();
        //    while (sdr.Read())
        //    {
        //        ogrenci = OgrenciBilgileriYukle(sdr);
        //    }
        //    sdr.Close();
        //    k.Temizle();

        //    return ogrenci;
        //}
        //private static Varlıklar.ogrders OgrenciBilgileriYukle(SqlDataReader sdr)
        //{
        //    Varlıklar.ogrders ogrenci = new Varlıklar.ogrders();
        //    try
        //    {
        //        ogrenci.Ogrid = komut.Int32Getir(sdr, "Ogrenci ID");
        //        ogrenci.Dersno = komut.Int32Getir(sdr, "Ders No");
        //        ogrenci.Vize = komut.Int32Getir(sdr, "Vize");
        //        ogrenci.Final = komut.Int32Getir(sdr, "Final");
        //        ogrenci.Ortalama = komut.Int32Getir(sdr, "Ortalama");
        //        ogrenci.Harfnotu = komut.StringGetir(sdr, "Harf Notu");
        //    }
        //    catch (Exception ex)
        //    {
        //        Yardimci.HataKaydet(ex);
        //        ogrenci = null;
        //    }
        //    return ogrenci;
        //}
    }
}
