using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varlıklar
{
  public  class ogrenci
    {
        protected int ogrid;
        protected int ogrno;
        protected string tcno;
        protected string ogrAdSoyad;
        protected string ogrBolum;
        protected string sinif;
        protected string ceptel;
        protected string mail;

        public int Ogrid
        {
            get { return ogrid; }
            set { ogrid = value; }
        }
        public int Ogrno
        {
            get { return ogrno; }
            set { ogrno = value; }
        }
        public string Tcno
        {
            get { return tcno; }
            set { tcno = value.Trim(); }
        }
        public string OgrAdSoyad
        {
            get { return ogrAdSoyad; }
            set {ogrAdSoyad = value; }
        }
        public string OgrBolum
        {
            get { return ogrBolum; }
            set { ogrBolum = value; }
        }
        public string Sinif
        {
            get { return sinif; }
            set { sinif = value; }
        }
        public string Ceptel
        {
            get { return ceptel; }
            set { ceptel = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public ogrenci(int ogrno, string tcno, string adsoyad, string bolum, string sinif, string ceptel, string mail)
        {
            this.Ogrno = ogrno;
            this.Tcno = tcno;
            this.OgrAdSoyad = adsoyad;
            this.OgrBolum = bolum;
            this.Sinif = sinif;
            this.Ceptel = ceptel;
            this.Mail = mail;

        }
        public ogrenci(int id)
        {
            this.Ogrid = id;
        }
    }
}
