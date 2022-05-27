using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OBS_1
{
  public  class Yardimci
    {
        public static int KullaniciNo = 0;

        public static void HataKaydet(Exception ex)
        {
            // Hata işletim sisteminin
            // olay günlüğüne yazılıyor
            string dosyaAdi = Environment.CurrentDirectory
            //+ \\SISWin_Hata_ 
                + Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi, ex.ToString());
        }

    }
}

namespace VeriErisimKatmani
{
    public class Yardimci
    {
        public static void HataKaydet(Exception ex)
        {
            // Hata işletim sisteminin
            // olay günlüğüne yazılıyor
            string dosyaAdi = Environment.CurrentDirectory
           //  + \\SISVeriErisimKatmani_Hata_ 
                + Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi, ex.ToString());
        }
    }
}
 
