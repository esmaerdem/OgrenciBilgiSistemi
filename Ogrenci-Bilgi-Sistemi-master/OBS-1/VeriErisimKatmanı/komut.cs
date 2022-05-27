using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VeriErisimKatmanı
{
  public  class komut
    {
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;

        internal komut(string spAdi)
        {
            cnn = baglanti.BaglantiGetir();
            komutOlustur(spAdi);
        }
        internal komut(string spAdi, SqlConnection baglanti)
        {
            this.cnn = baglanti;
            komutOlustur(spAdi);
        }
        private void komutOlustur(string spAdi)
        {
            try
            {
                cmd = cnn.CreateCommand();
                cmd.CommandText = spAdi;
                cmd.CommandType = CommandType.StoredProcedure;
            }
            catch (SqlException se)
            {
                throw new Exception("Komut oluşturulurken hata meydana geldi.", se);
            }
        }
        internal SqlParameter ParametreEkle(string ad, object deger)
        {
            SqlParameter prm = new SqlParameter(ad, deger);
            cmd.Parameters.Add(prm);
            return prm;
        }
        internal SqlParameter ParametreEkleOut(string ad, SqlDbType tip, int uzunluk)
        {
            SqlParameter prm = new SqlParameter();
            prm.ParameterName = ad;
            prm.SqlDbType = tip;
            if (uzunluk > 0)
            {
                prm.Size = uzunluk;
            }
            prm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prm);
            return prm;
        }
        internal bool IsletBool()
        {
            object sonuc = IsletSkaler();
            if (sonuc == null)
            {
                return false;
            }

            bool deger = (bool)sonuc;
            return deger;
        }
        private object IsletSkaler()
        {
            object sonuc = null;

            try
            {
                cnn.Open();
                sonuc = cmd.ExecuteScalar();
                return sonuc;
            }
            catch (SqlException se)
            {
                Yardimci.HataKaydet(se);
            }
            finally
            {
                cnn.Close();
            }
            return sonuc;
        }
        internal void Temizle()
        {
           baglanti.BaglantiSonlandir(cnn);
            cmd.Dispose();
        }

        internal int IsletInt32()
        {
            object sonuc = IsletSkaler();
            if (sonuc == null)
            {
                return 0;
            }

            int deger = (int)sonuc;
            return deger;
        }
        internal SqlDataReader IsletReader()
        {
            try
            {
                SqlDataReader sdr;
                cnn.Open();
                sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return sdr;
            }
            catch (SqlException se)
            {
                throw new Exception("Veritabanı işlem hatası", se);
            }
        }

        internal int Islet()
        {
            int etkilenen = 0;

            try
            {
                cnn.Open();
                etkilenen = cmd.ExecuteNonQuery();
                return etkilenen;
            }
            catch (SqlException se)
            {
                throw new Exception("Veritabanı işlem hatası", se);
            }
            finally
            {
                cnn.Close();
            }
        }
        internal int OutParametreDegeriGetir(string parametreAdi)
        {
            object deger = cmd.Parameters[parametreAdi].Value;
            if (deger != null)
            {
                return (int)deger;
            }
            else
            {
                return 0;
            }
        }
        internal static string StringGetir(SqlDataReader rdr, string alan)
        {
            string veri = string.Empty;
            int indeks = rdr.GetOrdinal(alan);
            if (!rdr.IsDBNull(indeks))
            {
                veri = rdr.GetString(indeks);
            }
            return veri;
        }

        internal static int Int32Getir(SqlDataReader rdr, string alan)
        {
            int veri = -1;
            int indeks = rdr.GetOrdinal(alan);
            if (!rdr.IsDBNull(indeks))
            {
                veri = rdr.GetInt32(indeks);
            }
            return veri;
        }

        internal static int Int16Getir(SqlDataReader rdr, string alan)
        {
            int veri = -1;
            int indeks = rdr.GetOrdinal(alan);
            if (!rdr.IsDBNull(indeks))
            {
                veri = rdr.GetInt16(indeks);
            }
            return veri;
        }

        internal static DateTime TarihGetir(SqlDataReader rdr, string alan)
        {
            DateTime veri = DateTime.MinValue;
            int indeks = rdr.GetOrdinal(alan);
            if (!rdr.IsDBNull(indeks))
            {
                veri = rdr.GetDateTime(indeks);
            }
            return veri;
        }

        internal static bool BoolGetir(SqlDataReader rdr, string alan)
        {
            bool veri = false;
            int indeks = rdr.GetOrdinal(alan);
            if (!rdr.IsDBNull(indeks))
            {
                veri = rdr.GetBoolean(indeks);
            }
            return veri;
        }
    }
}

