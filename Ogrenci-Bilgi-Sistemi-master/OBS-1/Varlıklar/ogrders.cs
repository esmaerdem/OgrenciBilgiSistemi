using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varlıklar
{
   public class ogrders
    {
        protected int ogrid;
        protected int dersno;
        protected int vize;
        protected int final;
        protected string ortalama;
        protected string harfnotu;

        public int Ogrid
        {
            get { return ogrid; }
            set { ogrid = value; }
        }
        public int Dersno
        {
            get { return dersno; }
            set { dersno = value; }
        }
        public int Vize
        {
            get { return vize; }
            set { vize = value; }
        }
        public int Final
        {
            get { return final; }
            set { final = value; }
        }
        public string Ortalama
        {
            get { return ortalama; }
            set { ortalama = value; }
        }
        public string Harfnotu
        {
            get { return harfnotu; }
            set { harfnotu = value; }
        }
        public ogrders(int ogrid, int dersno)
        {
            this.Ogrid = ogrid;
            this.Dersno = dersno;
        }
        public ogrders(int id, int dersno, int vize, int final, string ortalama, string harfnotu)
        {
            this.Ogrid = id;
            this.Dersno = dersno;
            this.Vize = vize;
            this.Final = final;
            this.Ortalama = ortalama;
            this.Harfnotu = harfnotu;
        }
    }
}
