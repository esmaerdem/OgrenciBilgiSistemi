using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace IsKatmanı
{
   public class Yardimci
    {
        public static void HataKaydet(Exception ex)
        {
            // Hata işletim sisteminin
            // olay günlüğüne yazılıyor
            string dosyaAdi = Environment.CurrentDirectory
           // + IsKatmani_Hata_ 
            + Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi, ex.ToString());
        }
        public static void YeniParolaEpostasiYolla(string eposta, string parola)
        {
            SmtpClient sc = new SmtpClient();
            sc.Host = "betulaslan94@hotmail.com";

            NetworkCredential crd
            = new NetworkCredential("hesap", "parola");
            sc.Credentials = crd;

            MailMessage msj = new MailMessage();
            msj.From = new MailAddress("gonderen@hesapadi.com");
            msj.To.Add(eposta);
            msj.Subject = "Parola değişikliği...";
            msj.Body = "Yeni parolanız: " +parola;
            try
            {
                sc.Send(msj);
            }
            catch (Exception ex)
            {
                HataKaydet(ex);
            }
        }

        public static string ParolaOlustur()
        {
            //
            //Random r = new Random();
            //return r.Next(100, 999).ToString();

            return "123";
        }
    }
}

