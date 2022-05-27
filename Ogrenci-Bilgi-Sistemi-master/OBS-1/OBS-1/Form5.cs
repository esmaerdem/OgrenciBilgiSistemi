using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISK = IsKatmanı;
using VAR = Varlıklar;

namespace OBS_1
{
    public partial class Form5 : Form
    {
        public VAR.ogrenci ogrenci;
        public Form5()
        {
            InitializeComponent();
        }

        // int ve string olarak değişken tanımladık form3 den gelen verileri almak için

        public  int ogrno=0;
        public  string tcno, ogrAdSoyad, ogrBolum, sinif, cep, mail;


        private void OgrenciDuzenle()
        {
            txtOgrNo.Text = ogrenci.Ogrno.ToString();
            txtTcNo.Text = ogrenci.Tcno;
            txtAdSoyad.Text = ogrenci.OgrAdSoyad;
            txtBolum.Text = ogrenci.OgrBolum;
            txtSinif.Text = ogrenci.Sinif;
            txtCepTel.Text = ogrenci.Ceptel;
            txtMail.Text = ogrenci.Mail;
        }
        private bool KullaniciGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(txtOgrNo.Text))
            {
                MessageBox.Show("Öğrenci numarasını boş geçemezsiniz.");
                txtOgrNo.SelectAll();
                txtOgrNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTcNo.Text))
            {
                MessageBox.Show("Tc numarası bilgisini boş geçemezsiniz.");
                txtTcNo.SelectAll();
                txtTcNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAdSoyad.Text))
            {
                MessageBox.Show("İsim bilgisini boş geçemezsiniz.");
                txtAdSoyad.SelectAll();
                txtAdSoyad.Focus();
                return false;
            }

            return true;
        }

        VeriErisimKatmanı.ogrenci yeniogrenci = new VeriErisimKatmanı.ogrenci();
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            VAR.ogrenci yogrenci = new Varlıklar.ogrenci(Convert.ToInt32(txtOgrNo.Text), txtTcNo.Text, txtAdSoyad.Text, txtBolum.Text, txtSinif.Text, txtCepTel.Text, txtMail.Text);
            yogrenci.Ogrid = yeniogrenci.Guncelle(yogrenci);
            ((Form3)this.Owner).ogrlistele();

            this.Visible = false;
            }
            catch { MessageBox.Show("Hatalı işlem."); }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //Düzenlenecek verileri texboxlara attık

            txtOgrNo.Text = ogrno.ToString();
            txtTcNo.Text = tcno;
            txtAdSoyad.Text = ogrAdSoyad;
            txtBolum.Text = ogrBolum;
            txtSinif.Text = sinif;
            txtCepTel.Text = cep;
            txtMail.Text = mail;
        }
    }
}
