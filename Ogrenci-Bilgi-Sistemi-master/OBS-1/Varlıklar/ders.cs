using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varlıklar
{
   public class ders
    {
        protected int dersno;
        protected string dersadi=String.Empty;
        protected string bolum = String.Empty;
        protected string hocasi = String.Empty;
        protected string donem = String.Empty;

        public int Dersno
        {
            get { return dersno; }
            set { dersno = value;  }
        }
        public string Dersadi
        {
            get { return dersadi; }
            set { dersadi = value; }
        }
        public string Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }
        public string Hocasi
        {
            get { return hocasi; }
            set { hocasi = value; }
        }
        public string Donem
        {
            get { return donem; }
            set { donem = value; }
        }
        public ders(string dersadi, string bolum, string hocasi, string donem)
        {
            this.Dersadi = dersadi;
            this.Bolum = bolum;
            this.Hocasi = hocasi;
            this.Donem = donem;
        }
        public ders(int dersno)
        {
            this.Dersno = dersno;
        }
    }
}
