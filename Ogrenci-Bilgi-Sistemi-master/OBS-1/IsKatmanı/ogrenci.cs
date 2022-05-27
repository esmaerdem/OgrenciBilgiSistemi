using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKatmanı
{
   public class ogrenci
    {
        public static int KullaniciGirisiDogrula(string ogrno, string tcno)
        {
            int sonuc = 0;
            sonuc = VeriErisimKatmanı.ogrenci.KullaniciGirisiDogrula(ogrno, tcno);
            return sonuc;
        }
        //public static int veri(string ogrno)
        //{
        //    int sonuc = 0;
        //    sonuc = VeriErisimKatmanı.ogrenci.veri(ogrno);
        //    return sonuc;
        //}
        //public static int OgrEkle(Varlıklar.ogrenci ogrenci)
        //{
        //    //bool sonuc = false;
        //    //if (ogrenci.Ogrid > 0)
        //    //{
        //    //    sonuc = VeriErisimKatmanı.ogrenci.ogrGuncelle(ogrenci);
        //    //}
        //    //else { sonuc = VeriErisimKatmanı.ogrenci.ogrKaydet(ogrenci); }
        //    //if (sonuc)
        //    //{
        //    //    return ogrenci.Ogrid;
        //    //}
        //    //else { return 0; }
            
        //}
        //public static int OgrGuncelle(Varlıklar.ogrenci ogrenci)
        //{
        //    bool sonuc = false;
        //    if (ogrenci.Ogrid > 0)
        //    {
        //        sonuc = VeriErisimKatmanı.ogrenci.ogrGuncelle(ogrenci);
        //    }
        //    if (sonuc)
        //    {
        //        return ogrenci.Ogrid;
        //    }
        //    else { return 0; }

        //}
        //public static Varlıklar.ogrders OgrenciGetir(int ogrenciNo)
        //{
        //    Varlıklar.ogrders ogrenci = null;
        //    ogrenci = VeriErisimKatmanı.ogrenci.ogrencigetir(ogrenciNo);

        //    return ogrenci;
        //}
    }
}
