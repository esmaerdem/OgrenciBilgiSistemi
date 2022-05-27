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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            int ogrenciNo = 0;
            // servis çağırılıyor
            try
            {
                ogrenciNo = ISK.ogrenci.KullaniciGirisiDogrula(textBox1.Text, textBox2.Text);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            if (ogrenciNo > 0)
            {
                Yardimci.KullaniciNo = ogrenciNo;
                this.Close();
                Form9 form9 = new Form9();
                this.Visible = false;
                form9.veri(Convert.ToInt32(textBox1.Text));
                form9.ShowDialog();
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
