using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISK = IsKatmanı;
using VAR = Varlıklar;
using System.Windows.Forms;

namespace OBS_1
{
    public partial class Form6 : Form
    {
        public VAR.ders ders;
        public Form6()
        {
            InitializeComponent();
        }
        private void DersYukle()
        {
            textBox1.Text = ders.Dersadi;
            textBox2.Text = ders.Bolum;
            textBox3.Text = ders.Hocasi;
            textBox4.Text = ders.Donem;
        }
        private bool KullaniciGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ders adını boş geçemezsiniz.");
                textBox1.SelectAll();
                textBox1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Dönem bilgisini boş geçemezsiniz.");
                textBox4.SelectAll();
                textBox4.Focus();
                return false;
            }

            return true;
        }

        VeriErisimKatmanı.ders yeniders = new VeriErisimKatmanı.ders();
        private void button1_Click(object sender, EventArgs e)
        {
            try{ 
            VAR.ders yders = new Varlıklar.ders(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            yders.Dersno = yeniders.DEkle(yders);
            ((Form3)this.Owner).derslistele();

            this.Visible = false;
            }
            catch { MessageBox.Show("Hatalı işlem."); }
        }
    }
}
