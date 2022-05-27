using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varlıklar
{
   public class yonetici
    {
        protected int yno;
        protected string yAdSoyad;
        protected string sifre;

        public int Yno
        {
            get { return yno; }
            set { yno = value; }
        }
        public string YAdSoyad
        {
            get { return yAdSoyad; }
            set { yAdSoyad = value; }
        }
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
    }
}
