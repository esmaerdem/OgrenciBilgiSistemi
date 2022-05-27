using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VeriErisimKatmanı
{
   public class Yardimci
    {
        public static void HataKaydet(Exception ex)
        {
            // Hata işletim sisteminin
            // olay günlüğüne yazılıyor
            string dosyaAdi = Environment.CurrentDirectory
                //  +\\VeriErisimKatmani_Hata_ 
                + Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi, ex.ToString());
        }
    }
}
