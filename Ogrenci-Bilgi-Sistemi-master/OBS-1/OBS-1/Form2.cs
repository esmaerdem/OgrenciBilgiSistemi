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
    public partial class Form2 : Form
    {
        public VAR.yonetici yonetici;
        public Form2()
        {
            InitializeComponent();
        }
       private void kullaniciGiris()
        {
            textBox1.Text = yonetici.YAdSoyad;
            textBox2.Text = yonetici.Sifre;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Kullanıcı bilgisini boş geçemezsiniz.");
                textBox1.SelectAll();
               textBox1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Parola bilgisini boş geçemezsiniz.");
                textBox2.SelectAll();
                textBox2.Focus();
                return;
            }
            int yoneticiNo = 0;
            // servis çağırılıyor
            try
            {
                yoneticiNo = ISK.yonetici.KullaniciGirisiDogrula(textBox1.Text, textBox2.Text);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            if (yoneticiNo > 0)
            {
                Yardimci.KullaniciNo = yoneticiNo;
                this.Close();
                Form3 form3 = new Form3();
                this.Visible = false;
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı / parola bilgisi!");
                textBox1.SelectAll();
                textBox1.Focus();
            }
        }
    }
}
