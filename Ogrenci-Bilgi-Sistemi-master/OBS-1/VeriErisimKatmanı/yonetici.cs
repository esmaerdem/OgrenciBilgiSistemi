using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmanı
{
   public class yonetici
    {
        public static int KullaniciGirisiDogrula(string yAdSoyad, string sifre)
        {
            string spAdi = "yoneticigiris";
            komut k = new komut(spAdi);
            k.ParametreEkle("@yAdSoyad", yAdSoyad);
            k.ParametreEkle("@sifre", sifre);

            int sonuc = k.IsletInt32();
            k.Temizle();

            return sonuc;
        }
    }
}
