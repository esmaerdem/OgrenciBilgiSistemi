using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKatmanı
{
   public class yonetici
    {
        public static int KullaniciGirisiDogrula(string yAdSoyad, string sifre)
        {
            int sonuc = 0;
            sonuc = VeriErisimKatmanı.yonetici.KullaniciGirisiDogrula(yAdSoyad, sifre);
            return sonuc;
        }
    }
}
